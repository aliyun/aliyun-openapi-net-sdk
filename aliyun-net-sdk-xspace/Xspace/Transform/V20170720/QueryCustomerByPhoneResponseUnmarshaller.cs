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
using Aliyun.Acs.xspace.Model.V20170720;

namespace Aliyun.Acs.xspace.Transform.V20170720
{
    public class QueryCustomerByPhoneResponseUnmarshaller
    {
        public static QueryCustomerByPhoneResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCustomerByPhoneResponse queryCustomerByPhoneResponse = new QueryCustomerByPhoneResponse();

			queryCustomerByPhoneResponse.HttpResponse = context.HttpResponse;
			queryCustomerByPhoneResponse.RequestId = context.StringValue("QueryCustomerByPhone.RequestId");
			queryCustomerByPhoneResponse.Success = context.BooleanValue("QueryCustomerByPhone.Success");
			queryCustomerByPhoneResponse.Code = context.StringValue("QueryCustomerByPhone.Code");
			queryCustomerByPhoneResponse.Message = context.StringValue("QueryCustomerByPhone.Message");

			List<QueryCustomerByPhoneResponse.QueryCustomerByPhone_DataItem> queryCustomerByPhoneResponse_data = new List<QueryCustomerByPhoneResponse.QueryCustomerByPhone_DataItem>();
			for (int i = 0; i < context.Length("QueryCustomerByPhone.Data.Length"); i++) {
				QueryCustomerByPhoneResponse.QueryCustomerByPhone_DataItem dataItem = new QueryCustomerByPhoneResponse.QueryCustomerByPhone_DataItem();
				dataItem.Detail = context.StringValue("QueryCustomerByPhone.Data["+ i +"].Detail");
				dataItem.Photo = context.StringValue("QueryCustomerByPhone.Data["+ i +"].Photo");
				dataItem.Id = context.StringValue("QueryCustomerByPhone.Data["+ i +"].Id");
				dataItem.Phone = context.StringValue("QueryCustomerByPhone.Data["+ i +"].Phone");
				dataItem.Gender = context.StringValue("QueryCustomerByPhone.Data["+ i +"].Gender");
				dataItem.Email = context.StringValue("QueryCustomerByPhone.Data["+ i +"].Email");
				dataItem.Nick = context.StringValue("QueryCustomerByPhone.Data["+ i +"].Nick");
				dataItem.RealName = context.StringValue("QueryCustomerByPhone.Data["+ i +"].RealName");

				List<string> dataItem_tags = new List<string>();
				for (int j = 0; j < context.Length("QueryCustomerByPhone.Data["+ i +"].Tags.Length"); j++) {
					dataItem_tags.Add(context.StringValue("QueryCustomerByPhone.Data["+ i +"].Tags["+ j +"]"));
				}
				dataItem.Tags = dataItem_tags;

				QueryCustomerByPhoneResponse.QueryCustomerByPhone_DataItem.QueryCustomerByPhone_CustomizeFields customizeFields = new QueryCustomerByPhoneResponse.QueryCustomerByPhone_DataItem.QueryCustomerByPhone_CustomizeFields();
				customizeFields.Cid = context.StringValue("QueryCustomerByPhone.Data["+ i +"].CustomizeFields.Cid");
				customizeFields.AbcUrl = context.StringValue("QueryCustomerByPhone.Data["+ i +"].CustomizeFields.AbcUrl");
				customizeFields.DistributionLevel = context.StringValue("QueryCustomerByPhone.Data["+ i +"].CustomizeFields.DistributionLevel");
				customizeFields.MainAccountUid = context.StringValue("QueryCustomerByPhone.Data["+ i +"].CustomizeFields.MainAccountUid");

				List<string> customizeFields_associatePersonList = new List<string>();
				for (int j = 0; j < context.Length("QueryCustomerByPhone.Data["+ i +"].CustomizeFields.AssociatePersonList.Length"); j++) {
					customizeFields_associatePersonList.Add(context.StringValue("QueryCustomerByPhone.Data["+ i +"].CustomizeFields.AssociatePersonList["+ j +"]"));
				}
				customizeFields.AssociatePersonList = customizeFields_associatePersonList;
				dataItem.CustomizeFields = customizeFields;

				queryCustomerByPhoneResponse_data.Add(dataItem);
			}
			queryCustomerByPhoneResponse.Data = queryCustomerByPhoneResponse_data;
        
			return queryCustomerByPhoneResponse;
        }
    }
}
