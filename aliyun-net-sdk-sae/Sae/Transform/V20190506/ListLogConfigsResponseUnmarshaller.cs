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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class ListLogConfigsResponseUnmarshaller
    {
        public static ListLogConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLogConfigsResponse listLogConfigsResponse = new ListLogConfigsResponse();

			listLogConfigsResponse.HttpResponse = _ctx.HttpResponse;
			listLogConfigsResponse.RequestId = _ctx.StringValue("ListLogConfigs.RequestId");
			listLogConfigsResponse.Code = _ctx.StringValue("ListLogConfigs.Code");
			listLogConfigsResponse.Message = _ctx.StringValue("ListLogConfigs.Message");
			listLogConfigsResponse.Success = _ctx.BooleanValue("ListLogConfigs.Success");
			listLogConfigsResponse.ErrorCode = _ctx.StringValue("ListLogConfigs.ErrorCode");
			listLogConfigsResponse.TraceId = _ctx.StringValue("ListLogConfigs.TraceId");

			ListLogConfigsResponse.ListLogConfigs_Data data = new ListLogConfigsResponse.ListLogConfigs_Data();
			data.CurrentPage = _ctx.IntegerValue("ListLogConfigs.Data.CurrentPage");
			data.PageSize = _ctx.IntegerValue("ListLogConfigs.Data.PageSize");
			data.TotalSize = _ctx.IntegerValue("ListLogConfigs.Data.TotalSize");

			List<ListLogConfigsResponse.ListLogConfigs_Data.ListLogConfigs_LogConfig> data_logConfigs = new List<ListLogConfigsResponse.ListLogConfigs_Data.ListLogConfigs_LogConfig>();
			for (int i = 0; i < _ctx.Length("ListLogConfigs.Data.LogConfigs.Length"); i++) {
				ListLogConfigsResponse.ListLogConfigs_Data.ListLogConfigs_LogConfig logConfig = new ListLogConfigsResponse.ListLogConfigs_Data.ListLogConfigs_LogConfig();
				logConfig.ConfigName = _ctx.StringValue("ListLogConfigs.Data.LogConfigs["+ i +"].ConfigName");
				logConfig.LogDir = _ctx.StringValue("ListLogConfigs.Data.LogConfigs["+ i +"].LogDir");
				logConfig.SlsProject = _ctx.StringValue("ListLogConfigs.Data.LogConfigs["+ i +"].SlsProject");
				logConfig.SlsLogStore = _ctx.StringValue("ListLogConfigs.Data.LogConfigs["+ i +"].SlsLogStore");
				logConfig.StoreType = _ctx.StringValue("ListLogConfigs.Data.LogConfigs["+ i +"].StoreType");
				logConfig.LogType = _ctx.StringValue("ListLogConfigs.Data.LogConfigs["+ i +"].LogType");
				logConfig.RegionId = _ctx.StringValue("ListLogConfigs.Data.LogConfigs["+ i +"].RegionId");
				logConfig.CreateTime = _ctx.StringValue("ListLogConfigs.Data.LogConfigs["+ i +"].CreateTime");

				data_logConfigs.Add(logConfig);
			}
			data.LogConfigs = data_logConfigs;
			listLogConfigsResponse.Data = data;
        
			return listLogConfigsResponse;
        }
    }
}
