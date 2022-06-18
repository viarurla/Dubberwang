FROM node:alpine

RUN mkdir -p /usr/src/app
ENV PORT 3000

WORKDIR /usr/src/app

COPY client/package.json /usr/src/app
COPY client/.eslintrc.json /usr/src/app
COPY client/next.config.js /usr/src/app
COPY client/yarn.lock /usr/src/app

# Production use node instead of root
# USER node

RUN yarn install --production

COPY client/pages /usr/src/app/pages
COPY client/components /usr/src/app/components
COPY client/public /usr/src/app/public

RUN npx next build

EXPOSE 3000
CMD [ "yarn", "start" ]