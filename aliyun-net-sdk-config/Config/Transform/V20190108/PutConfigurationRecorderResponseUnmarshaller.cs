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

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Config.Model.V20190108;

namespace Aliyun.Acs.Config.Transform.V20190108
{
    public class PutConfigurationRecorderResponseUnmarshaller
    {
        public static PutConfigurationRecorderResponse Unmarshall(UnmarshallerContext context)
        {
			PutConfigurationRecorderResponse putConfigurationRecorderResponse = new PutConfigurationRecorderResponse();

			putConfigurationRecorderResponse.HttpResponse = context.HttpResponse;
			putConfigurationRecorderResponse.RequestId = context.StringValue("PutConfigurationRecorder.RequestId");

			PutConfigurationRecorderResponse.PutConfigurationRecorder_ConfigurationRecorder configurationRecorder = new PutConfigurationRecorderResponse.PutConfigurationRecorder_ConfigurationRecorder();
			configurationRecorder.AccountId = context.LongValue("PutConfigurationRecorder.ConfigurationRecorder.AccountId");
			configurationRecorder.ConfigurationRecorderStatus = context.StringValue("PutConfigurationRecorder.ConfigurationRecorder.ConfigurationRecorderStatus");
			configurationRecorder.OrganizationMasterId = context.LongValue("PutConfigurationRecorder.ConfigurationRecorder.OrganizationMasterId");
			configurationRecorder.OrganizationEnableStatus = context.StringValue("PutConfigurationRecorder.ConfigurationRecorder.OrganizationEnableStatus");

			List<string> configurationRecorder_resourceTypes = new List<string>();
			for (int i = 0; i < context.Length("PutConfigurationRecorder.ConfigurationRecorder.ResourceTypes.Length"); i++) {
				configurationRecorder_resourceTypes.Add(context.StringValue("PutConfigurationRecorder.ConfigurationRecorder.ResourceTypes["+ i +"]"));
			}
			configurationRecorder.ResourceTypes = configurationRecorder_resourceTypes;
			putConfigurationRecorderResponse.ConfigurationRecorder = configurationRecorder;
        
			return putConfigurationRecorderResponse;
        }
    }
}
