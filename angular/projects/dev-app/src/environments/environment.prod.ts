import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'Blogging',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44363',
    redirectUri: baseUrl,
    clientId: 'Blogging_App',
    responseType: 'code',
    scope: 'offline_access Blogging',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44363',
      rootNamespace: 'CatchException.Blogging',
    },
    Blogging: {
      url: 'https://localhost:44381',
      rootNamespace: 'CatchException.Blogging',
    },
  },
} as Environment;
