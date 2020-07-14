﻿using NUnit.Framework;
using System.Linq;
using JPL_API_Testing.SentryAPI.SentryDataApiService;

namespace JPL_API_Testing
{
    public class SentryTests
    {
        SentryDataApiService _scoutDataApiService = new SentryDataApiService();

        [Test]
        public void CallingAPI_CorrectVersionResponse()
        {
            Assert.That(_scoutDataApiService.SentryDataDTO.SentryData.signature.version, Is.EqualTo("1.1"));
        }

        [Test]
        public void CallingAPI_CorrectSourceResponse()
        {
            Assert.That(_scoutDataApiService.SentryDataDTO.SentryData.signature.source, Is.EqualTo("NASA/JPL Sentry Data API"));
        }

        [Test]
        public void CallingAPI_CorrectCountResponse()
        {
            Assert.That(_scoutDataApiService.SentryDataDTO.SentryData.count, Is.EqualTo("1021"));
        }


    }
}