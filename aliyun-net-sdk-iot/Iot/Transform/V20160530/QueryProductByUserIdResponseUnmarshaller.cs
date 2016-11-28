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
using Aliyun.Acs.Iot.Model.V20160530;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Transform.V20160530
{
    public class QueryProductByUserIdResponseUnmarshaller
    {
        public static QueryProductByUserIdResponse Unmarshall(UnmarshallerContext context)
        {
			QueryProductByUserIdResponse queryProductByUserIdResponse = new QueryProductByUserIdResponse();

			queryProductByUserIdResponse.HttpResponse = context.HttpResponse;
			queryProductByUserIdResponse.RequestId = context.StringValue("QueryProductByUserId.RequestId");
			queryProductByUserIdResponse.Success = context.BooleanValue("QueryProductByUserId.Success");
			queryProductByUserIdResponse.ErrorMessage = context.StringValue("QueryProductByUserId.ErrorMessage");
			queryProductByUserIdResponse.PageSize = context.IntegerValue("QueryProductByUserId.PageSize");
			queryProductByUserIdResponse.PageCount = context.IntegerValue("QueryProductByUserId.PageCount");
			queryProductByUserIdResponse.Page = context.IntegerValue("QueryProductByUserId.Page");
			queryProductByUserIdResponse.Total = context.IntegerValue("QueryProductByUserId.Total");

			List<QueryProductByUserIdResponse.ProductInfo> data = new List<QueryProductByUserIdResponse.ProductInfo>();
			for (int i = 0; i < context.Length("QueryProductByUserId.Data.Length"); i++) {
				QueryProductByUserIdResponse.ProductInfo productInfo = new QueryProductByUserIdResponse.ProductInfo();
				productInfo.ProductKey = context.StringValue("QueryProductByUserId.Data["+ i +"].ProductKey");
				productInfo.ProductName = context.StringValue("QueryProductByUserId.Data["+ i +"].ProductName");
				productInfo.CatId = context.LongValue("QueryProductByUserId.Data["+ i +"].CatId");
				productInfo.CreateUserId = context.LongValue("QueryProductByUserId.Data["+ i +"].CreateUserId");
				productInfo.ProductDesc = context.StringValue("QueryProductByUserId.Data["+ i +"].ProductDesc");
				productInfo.ProductSecret = context.StringValue("QueryProductByUserId.Data["+ i +"].ProductSecret");
				productInfo.SecurePolicy = context.StringValue("QueryProductByUserId.Data["+ i +"].SecurePolicy");
				productInfo.FromSource = context.StringValue("QueryProductByUserId.Data["+ i +"].FromSource");
				productInfo.ExtProps = context.StringValue("QueryProductByUserId.Data["+ i +"].ExtProps");
				productInfo.GmtCreate = context.StringValue("QueryProductByUserId.Data["+ i +"].GmtCreate");
				productInfo.GmtModified = context.StringValue("QueryProductByUserId.Data["+ i +"].GmtModified");

				data.Add(productInfo);
			}
			queryProductByUserIdResponse.Data = data;
        
			return queryProductByUserIdResponse;
        }
    }
}