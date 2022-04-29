FROM node:17 AS node
FROM golang:1.17 AS provider-builder
ARG TARGETARCH
ENV PULUMICTL_VERSION=v0.0.29
RUN curl -sSLf "https://github.com/pulumi/pulumictl/releases/download/${PULUMICTL_VERSION}/pulumictl-${PULUMICTL_VERSION}-linux-${TARGETARCH}.tar.gz" | \
    tar xvz -C /tmp -f - pulumictl && \
    mv /tmp/pulumictl /usr/bin/

ENV PULUMI_VERSION=v3.24.1
RUN curl -fsSL https://get.pulumi.com -o /tmp/getpulumi.sh && \
    chmod +x /tmp/getpulumi.sh && \
    /tmp/getpulumi.sh --version="${PULUMI_VERSION}" && \
    ln -s /root/.pulumi/bin/* /usr/bin/

COPY . /go

RUN cd /go/provider && \
    go mod tidy && \
    cd /go && \
    make tfgen && \
    make provider

COPY --from=node /usr/local/bin/node /usr/local/bin/node
COPY --from=node /opt/yarn* /opt/yarn
COPY --from=node /usr/local/lib/node_modules /usr/local/lib/node_modules
RUN ln -s /usr/local/lib/node_modules/npm/bin/npm-cli.js /usr/local/bin/npm && \
    ln -s /opt/yarn/bin/* /usr/local/bin/ && \
    make build_nodejs && \
    sed -i.bak 's#\@pulumi/twingate#\@limewireofficial/twingate-pulumi#' sdk/nodejs/bin/package.json

