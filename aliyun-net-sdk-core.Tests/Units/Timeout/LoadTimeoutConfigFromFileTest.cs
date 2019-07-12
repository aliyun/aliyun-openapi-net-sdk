/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Timeout.Util;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Timeout
{
    public class LoadTimeoutConfigFromFileTest
    {
        private readonly string _product = "ecs";
        private readonly string _version = "2014-05-26";
        private readonly string _actionName = "CreateInstance";

        [Fact]
        public void TestApiTimeoutValue()
        {
            var loadTimeoutConfigFromFile = new LoadTimeoutConfigFromFile();

            var timeoutValue =
                loadTimeoutConfigFromFile.GetSpecificApiReadTimeoutValue(_product, _version, _actionName);

            Assert.Equal(86000, timeoutValue);
        }

        [Fact]
        public void TestParameterNull()
        {
            var loadTimeoutConfigFromFile = new LoadTimeoutConfigFromFile();

            var apiTimeoutValue = loadTimeoutConfigFromFile.GetSpecificApiReadTimeoutValue(_product, _version, null);

            Assert.Equal(0, apiTimeoutValue);
        }

        [Fact]
        public void TestCachedJsonData()
        {
            var loadTimeoutConfigFromFile = new LoadTimeoutConfigFromFile();

            Stopwatch sw = Stopwatch.StartNew();
            var apiTimeoutValue =
                loadTimeoutConfigFromFile.GetSpecificApiReadTimeoutValue(_product, _version, _actionName);
            var executeTime1 = sw.ElapsedMilliseconds;
            Assert.Equal(86000, apiTimeoutValue);

            sw.Restart();
            apiTimeoutValue =
                loadTimeoutConfigFromFile.GetSpecificApiReadTimeoutValue(_product, _version, "AllocateEipAddress");
            var executeTime2 = sw.ElapsedMilliseconds;

            Assert.Equal(17000, apiTimeoutValue);
        }

        [Fact]
        public void TestJsonDataNull()
        {
            var loadTimeoutConfigFromFile = new LoadTimeoutConfigFromFile();

            var apiTimeoutValue =
                loadTimeoutConfigFromFile.GetSpecificApiReadTimeoutValue(_product, _version, "error-actionName");

            Assert.Equal(0, apiTimeoutValue);
        }

        [Fact]
        public void TestLoadTimeoutFromFileException()
        {
            var loadTimeoutConfigFromFile = new LoadTimeoutConfigFromFile("fileNotFound.json");

            Assert.Throws<ClientException>(() =>
            {
                var apiValue =
                    loadTimeoutConfigFromFile.GetSpecificApiReadTimeoutValue(_product, _version, _actionName);
            });
        }
    }
}
