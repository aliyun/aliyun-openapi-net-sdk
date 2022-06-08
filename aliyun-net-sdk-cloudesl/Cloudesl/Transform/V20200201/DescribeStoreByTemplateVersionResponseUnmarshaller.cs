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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeStoreByTemplateVersionResponseUnmarshaller
    {
        public static DescribeStoreByTemplateVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStoreByTemplateVersionResponse describeStoreByTemplateVersionResponse = new DescribeStoreByTemplateVersionResponse();

			describeStoreByTemplateVersionResponse.HttpResponse = _ctx.HttpResponse;
			describeStoreByTemplateVersionResponse.RequestId = _ctx.StringValue("DescribeStoreByTemplateVersion.RequestId");
			describeStoreByTemplateVersionResponse.ErrorMessage = _ctx.StringValue("DescribeStoreByTemplateVersion.ErrorMessage");
			describeStoreByTemplateVersionResponse.Success = _ctx.BooleanValue("DescribeStoreByTemplateVersion.Success");
			describeStoreByTemplateVersionResponse.ErrorCode = _ctx.StringValue("DescribeStoreByTemplateVersion.ErrorCode");
			describeStoreByTemplateVersionResponse.Code = _ctx.StringValue("DescribeStoreByTemplateVersion.Code");
			describeStoreByTemplateVersionResponse.Message = _ctx.StringValue("DescribeStoreByTemplateVersion.Message");
			describeStoreByTemplateVersionResponse.DynamicMessage = _ctx.StringValue("DescribeStoreByTemplateVersion.DynamicMessage");
			describeStoreByTemplateVersionResponse.DynamicCode = _ctx.StringValue("DescribeStoreByTemplateVersion.DynamicCode");

			List<DescribeStoreByTemplateVersionResponse.DescribeStoreByTemplateVersion_SelectItemInfo> describeStoreByTemplateVersionResponse_stores = new List<DescribeStoreByTemplateVersionResponse.DescribeStoreByTemplateVersion_SelectItemInfo>();
			for (int i = 0; i < _ctx.Length("DescribeStoreByTemplateVersion.Stores.Length"); i++) {
				DescribeStoreByTemplateVersionResponse.DescribeStoreByTemplateVersion_SelectItemInfo selectItemInfo = new DescribeStoreByTemplateVersionResponse.DescribeStoreByTemplateVersion_SelectItemInfo();
				selectItemInfo.StoreName = _ctx.StringValue("DescribeStoreByTemplateVersion.Stores["+ i +"].StoreName");
				selectItemInfo.StoreId = _ctx.StringValue("DescribeStoreByTemplateVersion.Stores["+ i +"].StoreId");
				selectItemInfo.ParentId = _ctx.StringValue("DescribeStoreByTemplateVersion.Stores["+ i +"].ParentId");
				selectItemInfo.UserStoreCode = _ctx.StringValue("DescribeStoreByTemplateVersion.Stores["+ i +"].UserStoreCode");
				selectItemInfo.GmtModified = _ctx.StringValue("DescribeStoreByTemplateVersion.Stores["+ i +"].GmtModified");
				selectItemInfo.Phone = _ctx.StringValue("DescribeStoreByTemplateVersion.Stores["+ i +"].Phone");
				selectItemInfo.Level = _ctx.StringValue("DescribeStoreByTemplateVersion.Stores["+ i +"].Level");
				selectItemInfo.TemplateVersion = _ctx.StringValue("DescribeStoreByTemplateVersion.Stores["+ i +"].TemplateVersion");
				selectItemInfo.TimeZone = _ctx.StringValue("DescribeStoreByTemplateVersion.Stores["+ i +"].TimeZone");

				describeStoreByTemplateVersionResponse_stores.Add(selectItemInfo);
			}
			describeStoreByTemplateVersionResponse.Stores = describeStoreByTemplateVersionResponse_stores;
        
			return describeStoreByTemplateVersionResponse;
        }
    }
}
