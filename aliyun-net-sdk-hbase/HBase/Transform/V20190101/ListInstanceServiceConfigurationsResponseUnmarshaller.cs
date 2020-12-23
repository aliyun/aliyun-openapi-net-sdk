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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class ListInstanceServiceConfigurationsResponseUnmarshaller
    {
        public static ListInstanceServiceConfigurationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstanceServiceConfigurationsResponse listInstanceServiceConfigurationsResponse = new ListInstanceServiceConfigurationsResponse();

			listInstanceServiceConfigurationsResponse.HttpResponse = _ctx.HttpResponse;
			listInstanceServiceConfigurationsResponse.RequestId = _ctx.StringValue("ListInstanceServiceConfigurations.RequestId");
			listInstanceServiceConfigurationsResponse.PageNumber = _ctx.IntegerValue("ListInstanceServiceConfigurations.PageNumber");
			listInstanceServiceConfigurationsResponse.PageRecordCount = _ctx.IntegerValue("ListInstanceServiceConfigurations.PageRecordCount");
			listInstanceServiceConfigurationsResponse.TotalRecordCount = _ctx.LongValue("ListInstanceServiceConfigurations.TotalRecordCount");

			List<ListInstanceServiceConfigurationsResponse.ListInstanceServiceConfigurations_Config> listInstanceServiceConfigurationsResponse_configureList = new List<ListInstanceServiceConfigurationsResponse.ListInstanceServiceConfigurations_Config>();
			for (int i = 0; i < _ctx.Length("ListInstanceServiceConfigurations.ConfigureList.Length"); i++) {
				ListInstanceServiceConfigurationsResponse.ListInstanceServiceConfigurations_Config config = new ListInstanceServiceConfigurationsResponse.ListInstanceServiceConfigurations_Config();
				config.ConfigureName = _ctx.StringValue("ListInstanceServiceConfigurations.ConfigureList["+ i +"].ConfigureName");
				config.DefaultValue = _ctx.StringValue("ListInstanceServiceConfigurations.ConfigureList["+ i +"].DefaultValue");
				config.RunningValue = _ctx.StringValue("ListInstanceServiceConfigurations.ConfigureList["+ i +"].RunningValue");
				config.ConfigureUnit = _ctx.StringValue("ListInstanceServiceConfigurations.ConfigureList["+ i +"].ConfigureUnit");
				config.ValueRange = _ctx.StringValue("ListInstanceServiceConfigurations.ConfigureList["+ i +"].ValueRange");
				config.NeedRestart = _ctx.StringValue("ListInstanceServiceConfigurations.ConfigureList["+ i +"].NeedRestart");
				config.Description = _ctx.StringValue("ListInstanceServiceConfigurations.ConfigureList["+ i +"].Description");

				listInstanceServiceConfigurationsResponse_configureList.Add(config);
			}
			listInstanceServiceConfigurationsResponse.ConfigureList = listInstanceServiceConfigurationsResponse_configureList;
        
			return listInstanceServiceConfigurationsResponse;
        }
    }
}
