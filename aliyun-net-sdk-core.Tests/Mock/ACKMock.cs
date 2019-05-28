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

namespace Aliyun.Acs.Core.Tests.Mock
{
    public class ACKMock
    {
        public static string GetAccessKeyId(bool mock = false, string mockData = "AccessKeyId")
        {
            return mock ? mockData : GetEnv("ACCESS_KEY_ID", mockData);
        }

        public static string GetAccessKeySecret(bool mock = false, string mockData = "AccessKeySecret")
        {
            return mock ? mockData : GetEnv("ACCESS_KEY_SECRET", mockData);
        }

        public static string GetRoleName(bool mock = false, string mockData = "RoleName")
        {
            return mock ? mockData : GetEnv("RAM", mockData);
        }

        private static string GetEnv(string envName, string mockData)
        {
            return Environment.GetEnvironmentVariable(envName) == null
                ? mockData
                : Environment.GetEnvironmentVariable(envName);
        }
    }
}
