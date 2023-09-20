FROM node:16-alpine as development

COPY package*.json ./
RUN npm ci

FROM node:16-alpine As build

COPY package*.json ./
COPY --from=development /node_modules ./node_modules
COPY . .

RUN npm prune --production

CMD ["npm", "start"]