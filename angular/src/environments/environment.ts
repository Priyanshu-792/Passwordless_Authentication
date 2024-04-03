import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'PasswordlessAuthentication',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44383/',
    redirectUri: baseUrl,
    clientId: 'PasswordlessAuthentication_App',
    responseType: 'code',
    scope: 'offline_access PasswordlessAuthentication',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44383',
      rootNamespace: 'PasswordlessAuthentication',
    },
  },
} as Environment;
