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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeDrdsSqlAuditStatusResponseUnmarshaller
    {
        public static DescribeDrdsSqlAuditStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsSqlAuditStatusResponse describeDrdsSqlAuditStatusResponse = new DescribeDrdsSqlAuditStatusResponse();

			describeDrdsSqlAuditStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsSqlAuditStatusResponse.RequestId = _ctx.StringValue("DescribeDrdsSqlAuditStatus.RequestId");
			describeDrdsSqlAuditStatusResponse.Success = _ctx.BooleanValue("DescribeDrdsSqlAuditStatus.Success");

			List<DescribeDrdsSqlAuditStatusResponse.DescribeDrdsSqlAuditStatus_DataItem> describeDrdsSqlAuditStatusResponse_data = new List<DescribeDrdsSqlAuditStatusResponse.DescribeDrdsSqlAuditStatus_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsSqlAuditStatus.Data.Length"); i++) {
				DescribeDrdsSqlAuditStatusResponse.DescribeDrdsSqlAuditStatus_DataItem dataItem = new DescribeDrdsSqlAuditStatusResponse.DescribeDrdsSqlAuditStatus_DataItem();
				dataItem.DbName = _ctx.StringValue("DescribeDrdsSqlAuditStatus.Data["+ i +"].DbName");
				dataItem.Enabled = _ctx.StringValue("DescribeDrdsSqlAuditStatus.Data["+ i +"].Enabled");
				dataItem.Detailed = _ctx.StringValue("DescribeDrdsSqlAuditStatus.Data["+ i +"].Detailed");
				dataItem.ExtraWriteEnabled = _ctx.BooleanValue("DescribeDrdsSqlAuditStatus.Data["+ i +"].ExtraWriteEnabled");
				dataItem.ExtraAliUid = _ctx.LongValue("DescribeDrdsSqlAuditStatus.Data["+ i +"].ExtraAliUid");
				dataItem.ExtraSlsProject = _ctx.StringValue("DescribeDrdsSqlAuditStatus.Data["+ i +"].ExtraSlsProject");
				dataItem.ExtraSlsLogStore = _ctx.StringValue("DescribeDrdsSqlAuditStatus.Data["+ i +"].ExtraSlsLogStore");

				describeDrdsSqlAuditStatusResponse_data.Add(dataItem);
			}
			describeDrdsSqlAuditStatusResponse.Data = describeDrdsSqlAuditStatusResponse_data;
        
			return describeDrdsSqlAuditStatusResponse;
        }
    }
}
