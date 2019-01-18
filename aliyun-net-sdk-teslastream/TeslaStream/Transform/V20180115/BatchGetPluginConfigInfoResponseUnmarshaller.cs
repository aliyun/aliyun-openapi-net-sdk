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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.TeslaStream.Model.V20180115;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaStream.Transform.V20180115
{
    public class BatchGetPluginConfigInfoResponseUnmarshaller
    {
        public static BatchGetPluginConfigInfoResponse Unmarshall(UnmarshallerContext context)
        {
			BatchGetPluginConfigInfoResponse batchGetPluginConfigInfoResponse = new BatchGetPluginConfigInfoResponse();

			batchGetPluginConfigInfoResponse.HttpResponse = context.HttpResponse;
			batchGetPluginConfigInfoResponse.Code = context.IntegerValue("BatchGetPluginConfigInfo.Code");
			batchGetPluginConfigInfoResponse.Message = context.StringValue("BatchGetPluginConfigInfo.Message");
			batchGetPluginConfigInfoResponse.RequestId = context.StringValue("BatchGetPluginConfigInfo.RequestId");

			List<BatchGetPluginConfigInfoResponse.BatchGetPluginConfigInfo_Plugin> batchGetPluginConfigInfoResponse_data = new List<BatchGetPluginConfigInfoResponse.BatchGetPluginConfigInfo_Plugin>();
			for (int i = 0; i < context.Length("BatchGetPluginConfigInfo.Data.Length"); i++) {
				BatchGetPluginConfigInfoResponse.BatchGetPluginConfigInfo_Plugin plugin = new BatchGetPluginConfigInfoResponse.BatchGetPluginConfigInfo_Plugin();
				plugin.PluginProperties = context.StringValue("BatchGetPluginConfigInfo.Data["+ i +"].PluginProperties");
				plugin.PluginUniqKey = context.StringValue("BatchGetPluginConfigInfo.Data["+ i +"].PluginUniqKey");

				batchGetPluginConfigInfoResponse_data.Add(plugin);
			}
			batchGetPluginConfigInfoResponse.Data = batchGetPluginConfigInfoResponse_data;
        
			return batchGetPluginConfigInfoResponse;
        }
    }
}