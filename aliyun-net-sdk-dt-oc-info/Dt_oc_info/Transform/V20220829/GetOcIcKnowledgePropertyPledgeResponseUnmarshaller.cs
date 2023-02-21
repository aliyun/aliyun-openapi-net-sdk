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
using Aliyun.Acs.dt_oc_info.Model.V20220829;

namespace Aliyun.Acs.dt_oc_info.Transform.V20220829
{
    public class GetOcIcKnowledgePropertyPledgeResponseUnmarshaller
    {
        public static GetOcIcKnowledgePropertyPledgeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcKnowledgePropertyPledgeResponse getOcIcKnowledgePropertyPledgeResponse = new GetOcIcKnowledgePropertyPledgeResponse();

			getOcIcKnowledgePropertyPledgeResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcKnowledgePropertyPledgeResponse.Code = _ctx.StringValue("GetOcIcKnowledgePropertyPledge.Code");
			getOcIcKnowledgePropertyPledgeResponse.Success = _ctx.BooleanValue("GetOcIcKnowledgePropertyPledge.Success");
			getOcIcKnowledgePropertyPledgeResponse.Message = _ctx.StringValue("GetOcIcKnowledgePropertyPledge.Message");
			getOcIcKnowledgePropertyPledgeResponse.TotalNum = _ctx.IntegerValue("GetOcIcKnowledgePropertyPledge.TotalNum");
			getOcIcKnowledgePropertyPledgeResponse.PageIndex = _ctx.IntegerValue("GetOcIcKnowledgePropertyPledge.PageIndex");
			getOcIcKnowledgePropertyPledgeResponse.PageNum = _ctx.IntegerValue("GetOcIcKnowledgePropertyPledge.PageNum");
			getOcIcKnowledgePropertyPledgeResponse.RequestId = _ctx.StringValue("GetOcIcKnowledgePropertyPledge.RequestId");

			List<GetOcIcKnowledgePropertyPledgeResponse.GetOcIcKnowledgePropertyPledge_DataItem> getOcIcKnowledgePropertyPledgeResponse_data = new List<GetOcIcKnowledgePropertyPledgeResponse.GetOcIcKnowledgePropertyPledge_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIcKnowledgePropertyPledge.Data.Length"); i++) {
				GetOcIcKnowledgePropertyPledgeResponse.GetOcIcKnowledgePropertyPledge_DataItem dataItem = new GetOcIcKnowledgePropertyPledgeResponse.GetOcIcKnowledgePropertyPledge_DataItem();
				dataItem.Name = _ctx.StringValue("GetOcIcKnowledgePropertyPledge.Data["+ i +"].Name");
				dataItem.Number = _ctx.StringValue("GetOcIcKnowledgePropertyPledge.Data["+ i +"].Number");
				dataItem.Type = _ctx.StringValue("GetOcIcKnowledgePropertyPledge.Data["+ i +"].Type");
				dataItem.Pledgor = _ctx.StringValue("GetOcIcKnowledgePropertyPledge.Data["+ i +"].Pledgor");
				dataItem.Pawnee = _ctx.StringValue("GetOcIcKnowledgePropertyPledge.Data["+ i +"].Pawnee");
				dataItem.Period = _ctx.StringValue("GetOcIcKnowledgePropertyPledge.Data["+ i +"].Period");
				dataItem.Status = _ctx.StringValue("GetOcIcKnowledgePropertyPledge.Data["+ i +"].Status");
				dataItem.PublicDate = _ctx.StringValue("GetOcIcKnowledgePropertyPledge.Data["+ i +"].PublicDate");

				getOcIcKnowledgePropertyPledgeResponse_data.Add(dataItem);
			}
			getOcIcKnowledgePropertyPledgeResponse.Data = getOcIcKnowledgePropertyPledgeResponse_data;
        
			return getOcIcKnowledgePropertyPledgeResponse;
        }
    }
}
