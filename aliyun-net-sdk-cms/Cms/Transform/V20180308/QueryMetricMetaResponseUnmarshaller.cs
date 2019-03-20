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
using Aliyun.Acs.Cms.Model.V20180308;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class QueryMetricMetaResponseUnmarshaller
    {
        public static QueryMetricMetaResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMetricMetaResponse queryMetricMetaResponse = new QueryMetricMetaResponse();

			queryMetricMetaResponse.HttpResponse = context.HttpResponse;
			queryMetricMetaResponse.RequestId = context.StringValue("QueryMetricMeta.RequestId");
			queryMetricMetaResponse.Success = context.BooleanValue("QueryMetricMeta.Success");
			queryMetricMetaResponse.ErrorCode = context.StringValue("QueryMetricMeta.ErrorCode");
			queryMetricMetaResponse.ErrorMessage = context.StringValue("QueryMetricMeta.ErrorMessage");

			List<QueryMetricMetaResponse.QueryMetricMeta_Resource> queryMetricMetaResponse_resources = new List<QueryMetricMetaResponse.QueryMetricMeta_Resource>();
			for (int i = 0; i < context.Length("QueryMetricMeta.Resources.Length"); i++) {
				QueryMetricMetaResponse.QueryMetricMeta_Resource resource = new QueryMetricMetaResponse.QueryMetricMeta_Resource();
				resource.Project = context.StringValue("QueryMetricMeta.Resources["+ i +"].Project");
				resource.Metric = context.StringValue("QueryMetricMeta.Resources["+ i +"].Metric");
				resource.Statistics = context.StringValue("QueryMetricMeta.Resources["+ i +"].Statistics");
				resource.Unit = context.StringValue("QueryMetricMeta.Resources["+ i +"].Unit");
				resource.Description = context.StringValue("QueryMetricMeta.Resources["+ i +"].Description");
				resource.Dimensions = context.StringValue("QueryMetricMeta.Resources["+ i +"].Dimensions");
				resource.Periods = context.StringValue("QueryMetricMeta.Resources["+ i +"].Periods");
				resource.Labels = context.StringValue("QueryMetricMeta.Resources["+ i +"].Labels");

				queryMetricMetaResponse_resources.Add(resource);
			}
			queryMetricMetaResponse.Resources = queryMetricMetaResponse_resources;
        
			return queryMetricMetaResponse;
        }
    }
}
