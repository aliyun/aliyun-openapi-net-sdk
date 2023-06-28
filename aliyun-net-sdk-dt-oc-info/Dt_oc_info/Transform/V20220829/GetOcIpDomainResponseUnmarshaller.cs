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
using Aliyun.Acs.dt_oc_info.Model.V20220829;

namespace Aliyun.Acs.dt_oc_info.Transform.V20220829
{
    public class GetOcIpDomainResponseUnmarshaller
    {
        public static GetOcIpDomainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIpDomainResponse getOcIpDomainResponse = new GetOcIpDomainResponse();

			getOcIpDomainResponse.HttpResponse = _ctx.HttpResponse;
			getOcIpDomainResponse.Code = _ctx.StringValue("GetOcIpDomain.Code");
			getOcIpDomainResponse.Success = _ctx.BooleanValue("GetOcIpDomain.Success");
			getOcIpDomainResponse.Message = _ctx.StringValue("GetOcIpDomain.Message");
			getOcIpDomainResponse.TotalNum = _ctx.IntegerValue("GetOcIpDomain.TotalNum");
			getOcIpDomainResponse.PageIndex = _ctx.IntegerValue("GetOcIpDomain.PageIndex");
			getOcIpDomainResponse.PageNum = _ctx.IntegerValue("GetOcIpDomain.PageNum");
			getOcIpDomainResponse.RequestId = _ctx.StringValue("GetOcIpDomain.RequestId");

			List<GetOcIpDomainResponse.GetOcIpDomain_DataItem> getOcIpDomainResponse_data = new List<GetOcIpDomainResponse.GetOcIpDomain_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIpDomain.Data.Length"); i++) {
				GetOcIpDomainResponse.GetOcIpDomain_DataItem dataItem = new GetOcIpDomainResponse.GetOcIpDomain_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcIpDomain.Data["+ i +"].EntName");
				dataItem.Number = _ctx.StringValue("GetOcIpDomain.Data["+ i +"].Number");
				dataItem.Domain = _ctx.StringValue("GetOcIpDomain.Data["+ i +"].Domain");
				dataItem.SiteName = _ctx.StringValue("GetOcIpDomain.Data["+ i +"].SiteName");
				dataItem.HomeUrl = _ctx.StringValue("GetOcIpDomain.Data["+ i +"].HomeUrl");
				dataItem.CheckDate = _ctx.StringValue("GetOcIpDomain.Data["+ i +"].CheckDate");

				getOcIpDomainResponse_data.Add(dataItem);
			}
			getOcIpDomainResponse.Data = getOcIpDomainResponse_data;
        
			return getOcIpDomainResponse;
        }
    }
}
