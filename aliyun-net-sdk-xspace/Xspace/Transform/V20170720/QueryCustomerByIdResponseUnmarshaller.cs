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
    public class QueryCustomerByIdResponseUnmarshaller
    {
        public static QueryCustomerByIdResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCustomerByIdResponse queryCustomerByIdResponse = new QueryCustomerByIdResponse();

			queryCustomerByIdResponse.HttpResponse = context.HttpResponse;
			queryCustomerByIdResponse.RequestId = context.StringValue("QueryCustomerById.RequestId");
			queryCustomerByIdResponse.Success = context.BooleanValue("QueryCustomerById.Success");
			queryCustomerByIdResponse.Code = context.StringValue("QueryCustomerById.Code");
			queryCustomerByIdResponse.Message = context.StringValue("QueryCustomerById.Message");

			QueryCustomerByIdResponse.QueryCustomerById_Data data = new QueryCustomerByIdResponse.QueryCustomerById_Data();
			data.Id = context.StringValue("QueryCustomerById.Data.Id");
			data.Nick = context.StringValue("QueryCustomerById.Data.Nick");
			data.RealName = context.StringValue("QueryCustomerById.Data.RealName");
			data.Email = context.StringValue("QueryCustomerById.Data.Email");
			data.Phone = context.StringValue("QueryCustomerById.Data.Phone");
			data.Gender = context.StringValue("QueryCustomerById.Data.Gender");
			data.Photo = context.StringValue("QueryCustomerById.Data.Photo");
			data.Detail = context.StringValue("QueryCustomerById.Data.Detail");

			List<string> data_tags = new List<string>();
			for (int i = 0; i < context.Length("QueryCustomerById.Data.Tags.Length"); i++) {
				data_tags.Add(context.StringValue("QueryCustomerById.Data.Tags["+ i +"]"));
			}
			data.Tags = data_tags;

			QueryCustomerByIdResponse.QueryCustomerById_Data.QueryCustomerById_CustomizeFields customizeFields = new QueryCustomerByIdResponse.QueryCustomerById_Data.QueryCustomerById_CustomizeFields();
			customizeFields.Cid = context.StringValue("QueryCustomerById.Data.CustomizeFields.Cid");
			customizeFields.AbcUrl = context.StringValue("QueryCustomerById.Data.CustomizeFields.AbcUrl");

			List<string> customizeFields_associatePersonList = new List<string>();
			for (int i = 0; i < context.Length("QueryCustomerById.Data.CustomizeFields.AssociatePersonList.Length"); i++) {
				customizeFields_associatePersonList.Add(context.StringValue("QueryCustomerById.Data.CustomizeFields.AssociatePersonList["+ i +"]"));
			}
			customizeFields.AssociatePersonList = customizeFields_associatePersonList;
			data.CustomizeFields = customizeFields;
			queryCustomerByIdResponse.Data = data;
        
			return queryCustomerByIdResponse;
        }
    }
}
