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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class QuerySyncReportAggregationResponseUnmarshaller
    {
        public static QuerySyncReportAggregationResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySyncReportAggregationResponse querySyncReportAggregationResponse = new QuerySyncReportAggregationResponse();

			querySyncReportAggregationResponse.HttpResponse = context.HttpResponse;
			querySyncReportAggregationResponse.RequestId = context.StringValue("QuerySyncReportAggregation.RequestId");
			querySyncReportAggregationResponse.Code = context.StringValue("QuerySyncReportAggregation.Code");
			querySyncReportAggregationResponse.Message = context.StringValue("QuerySyncReportAggregation.Message");
			querySyncReportAggregationResponse.Result = context.StringValue("QuerySyncReportAggregation.Result");
        
			return querySyncReportAggregationResponse;
        }
    }
}
