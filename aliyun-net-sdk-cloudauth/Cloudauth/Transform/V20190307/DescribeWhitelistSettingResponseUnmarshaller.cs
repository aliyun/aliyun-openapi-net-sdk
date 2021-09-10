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
using Aliyun.Acs.Cloudauth.Model.V20190307;

namespace Aliyun.Acs.Cloudauth.Transform.V20190307
{
    public class DescribeWhitelistSettingResponseUnmarshaller
    {
        public static DescribeWhitelistSettingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWhitelistSettingResponse describeWhitelistSettingResponse = new DescribeWhitelistSettingResponse();

			describeWhitelistSettingResponse.HttpResponse = _ctx.HttpResponse;
			describeWhitelistSettingResponse.RequestId = _ctx.StringValue("DescribeWhitelistSetting.RequestId");
			describeWhitelistSettingResponse.TotalCount = _ctx.IntegerValue("DescribeWhitelistSetting.TotalCount");
			describeWhitelistSettingResponse.CurrentPage = _ctx.IntegerValue("DescribeWhitelistSetting.CurrentPage");
			describeWhitelistSettingResponse.PageSize = _ctx.IntegerValue("DescribeWhitelistSetting.PageSize");

			List<DescribeWhitelistSettingResponse.DescribeWhitelistSetting_Item> describeWhitelistSettingResponse_items = new List<DescribeWhitelistSettingResponse.DescribeWhitelistSetting_Item>();
			for (int i = 0; i < _ctx.Length("DescribeWhitelistSetting.Items.Length"); i++) {
				DescribeWhitelistSettingResponse.DescribeWhitelistSetting_Item item = new DescribeWhitelistSettingResponse.DescribeWhitelistSetting_Item();
				item.Id = _ctx.LongValue("DescribeWhitelistSetting.Items["+ i +"].Id");
				item.SceneId = _ctx.LongValue("DescribeWhitelistSetting.Items["+ i +"].SceneId");
				item.ValidStartDate = _ctx.StringValue("DescribeWhitelistSetting.Items["+ i +"].ValidStartDate");
				item.ValidEndDate = _ctx.StringValue("DescribeWhitelistSetting.Items["+ i +"].ValidEndDate");
				item.CertNo = _ctx.StringValue("DescribeWhitelistSetting.Items["+ i +"].CertNo");
				item.CertifyId = _ctx.StringValue("DescribeWhitelistSetting.Items["+ i +"].CertifyId");
				item.Status = _ctx.StringValue("DescribeWhitelistSetting.Items["+ i +"].Status");
				item.GmtCreate = _ctx.StringValue("DescribeWhitelistSetting.Items["+ i +"].GmtCreate");
				item.GmtModified = _ctx.StringValue("DescribeWhitelistSetting.Items["+ i +"].GmtModified");

				describeWhitelistSettingResponse_items.Add(item);
			}
			describeWhitelistSettingResponse.Items = describeWhitelistSettingResponse_items;
        
			return describeWhitelistSettingResponse;
        }
    }
}
