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
using Aliyun.Acs.Crm.Model.V20150408;

namespace Aliyun.Acs.Crm.Transform.V20150408
{
    public class QueryCustomerLabelResponseUnmarshaller
    {
        public static QueryCustomerLabelResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCustomerLabelResponse queryCustomerLabelResponse = new QueryCustomerLabelResponse();

			queryCustomerLabelResponse.HttpResponse = context.HttpResponse;
			queryCustomerLabelResponse.Success = context.BooleanValue("QueryCustomerLabel.Success");
			queryCustomerLabelResponse.Code = context.StringValue("QueryCustomerLabel.Code");
			queryCustomerLabelResponse.Message = context.StringValue("QueryCustomerLabel.Message");

			List<QueryCustomerLabelResponse.QueryCustomerLabel_CustomerLabel> queryCustomerLabelResponse_data = new List<QueryCustomerLabelResponse.QueryCustomerLabel_CustomerLabel>();
			for (int i = 0; i < context.Length("QueryCustomerLabel.Data.Length"); i++) {
				QueryCustomerLabelResponse.QueryCustomerLabel_CustomerLabel customerLabel = new QueryCustomerLabelResponse.QueryCustomerLabel_CustomerLabel();
				customerLabel.Label = context.StringValue("QueryCustomerLabel.Data["+ i +"].Label");
				customerLabel.LabelSeries = context.StringValue("QueryCustomerLabel.Data["+ i +"].LabelSeries");

				queryCustomerLabelResponse_data.Add(customerLabel);
			}
			queryCustomerLabelResponse.Data = queryCustomerLabelResponse_data;
        
			return queryCustomerLabelResponse;
        }
    }
}
