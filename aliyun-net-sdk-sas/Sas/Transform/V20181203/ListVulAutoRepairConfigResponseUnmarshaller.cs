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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class ListVulAutoRepairConfigResponseUnmarshaller
    {
        public static ListVulAutoRepairConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVulAutoRepairConfigResponse listVulAutoRepairConfigResponse = new ListVulAutoRepairConfigResponse();

			listVulAutoRepairConfigResponse.HttpResponse = _ctx.HttpResponse;
			listVulAutoRepairConfigResponse.RequestId = _ctx.StringValue("ListVulAutoRepairConfig.RequestId");
			listVulAutoRepairConfigResponse.Success = _ctx.BooleanValue("ListVulAutoRepairConfig.Success");
			listVulAutoRepairConfigResponse.Code = _ctx.StringValue("ListVulAutoRepairConfig.Code");
			listVulAutoRepairConfigResponse.Message = _ctx.StringValue("ListVulAutoRepairConfig.Message");
			listVulAutoRepairConfigResponse.HttpStatusCode = _ctx.IntegerValue("ListVulAutoRepairConfig.HttpStatusCode");

			ListVulAutoRepairConfigResponse.ListVulAutoRepairConfig_PageInfo pageInfo = new ListVulAutoRepairConfigResponse.ListVulAutoRepairConfig_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("ListVulAutoRepairConfig.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("ListVulAutoRepairConfig.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("ListVulAutoRepairConfig.PageInfo.TotalCount");
			pageInfo.Count = _ctx.IntegerValue("ListVulAutoRepairConfig.PageInfo.Count");
			listVulAutoRepairConfigResponse.PageInfo = pageInfo;

			List<ListVulAutoRepairConfigResponse.ListVulAutoRepairConfig_VulAutoRepairConfig> listVulAutoRepairConfigResponse_vulAutoRepairConfigList = new List<ListVulAutoRepairConfigResponse.ListVulAutoRepairConfig_VulAutoRepairConfig>();
			for (int i = 0; i < _ctx.Length("ListVulAutoRepairConfig.VulAutoRepairConfigList.Length"); i++) {
				ListVulAutoRepairConfigResponse.ListVulAutoRepairConfig_VulAutoRepairConfig vulAutoRepairConfig = new ListVulAutoRepairConfigResponse.ListVulAutoRepairConfig_VulAutoRepairConfig();
				vulAutoRepairConfig.Id = _ctx.LongValue("ListVulAutoRepairConfig.VulAutoRepairConfigList["+ i +"].Id");
				vulAutoRepairConfig.Name = _ctx.StringValue("ListVulAutoRepairConfig.VulAutoRepairConfigList["+ i +"].Name");
				vulAutoRepairConfig.Type = _ctx.StringValue("ListVulAutoRepairConfig.VulAutoRepairConfigList["+ i +"].Type");
				vulAutoRepairConfig.AliasName = _ctx.StringValue("ListVulAutoRepairConfig.VulAutoRepairConfigList["+ i +"].AliasName");
				vulAutoRepairConfig.Reason = _ctx.StringValue("ListVulAutoRepairConfig.VulAutoRepairConfigList["+ i +"].Reason");

				listVulAutoRepairConfigResponse_vulAutoRepairConfigList.Add(vulAutoRepairConfig);
			}
			listVulAutoRepairConfigResponse.VulAutoRepairConfigList = listVulAutoRepairConfigResponse_vulAutoRepairConfigList;
        
			return listVulAutoRepairConfigResponse;
        }
    }
}
