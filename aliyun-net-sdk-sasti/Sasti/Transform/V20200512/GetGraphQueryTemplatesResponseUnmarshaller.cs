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
using Aliyun.Acs.Sasti.Model.V20200512;

namespace Aliyun.Acs.Sasti.Transform.V20200512
{
    public class GetGraphQueryTemplatesResponseUnmarshaller
    {
        public static GetGraphQueryTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetGraphQueryTemplatesResponse getGraphQueryTemplatesResponse = new GetGraphQueryTemplatesResponse();

			getGraphQueryTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			getGraphQueryTemplatesResponse.RequestId = _ctx.StringValue("GetGraphQueryTemplates.RequestId");

			List<GetGraphQueryTemplatesResponse.GetGraphQueryTemplates_DataItem> getGraphQueryTemplatesResponse_data = new List<GetGraphQueryTemplatesResponse.GetGraphQueryTemplates_DataItem>();
			for (int i = 0; i < _ctx.Length("GetGraphQueryTemplates.Data.Length"); i++) {
				GetGraphQueryTemplatesResponse.GetGraphQueryTemplates_DataItem dataItem = new GetGraphQueryTemplatesResponse.GetGraphQueryTemplates_DataItem();
				dataItem.Id = _ctx.LongValue("GetGraphQueryTemplates.Data["+ i +"].Id");
				dataItem.GmtCreate = _ctx.StringValue("GetGraphQueryTemplates.Data["+ i +"].GmtCreate");
				dataItem.GmtModified = _ctx.StringValue("GetGraphQueryTemplates.Data["+ i +"].GmtModified");
				dataItem.Scenario = _ctx.StringValue("GetGraphQueryTemplates.Data["+ i +"].Scenario");
				dataItem.GremlinTemplate = _ctx.StringValue("GetGraphQueryTemplates.Data["+ i +"].GremlinTemplate");
				dataItem.LastModifier = _ctx.StringValue("GetGraphQueryTemplates.Data["+ i +"].LastModifier");
				dataItem.Status = _ctx.IntegerValue("GetGraphQueryTemplates.Data["+ i +"].Status");
				dataItem.ScenarioDesc = _ctx.StringValue("GetGraphQueryTemplates.Data["+ i +"].ScenarioDesc");

				getGraphQueryTemplatesResponse_data.Add(dataItem);
			}
			getGraphQueryTemplatesResponse.Data = getGraphQueryTemplatesResponse_data;
        
			return getGraphQueryTemplatesResponse;
        }
    }
}
