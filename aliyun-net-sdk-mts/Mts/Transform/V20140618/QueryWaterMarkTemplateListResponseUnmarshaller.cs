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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class QueryWaterMarkTemplateListResponseUnmarshaller
    {
        public static QueryWaterMarkTemplateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryWaterMarkTemplateListResponse queryWaterMarkTemplateListResponse = new QueryWaterMarkTemplateListResponse();

			queryWaterMarkTemplateListResponse.HttpResponse = _ctx.HttpResponse;
			queryWaterMarkTemplateListResponse.RequestId = _ctx.StringValue("QueryWaterMarkTemplateList.RequestId");

			List<string> queryWaterMarkTemplateListResponse_nonExistWids = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryWaterMarkTemplateList.NonExistWids.Length"); i++) {
				queryWaterMarkTemplateListResponse_nonExistWids.Add(_ctx.StringValue("QueryWaterMarkTemplateList.NonExistWids["+ i +"]"));
			}
			queryWaterMarkTemplateListResponse.NonExistWids = queryWaterMarkTemplateListResponse_nonExistWids;

			List<QueryWaterMarkTemplateListResponse.QueryWaterMarkTemplateList_WaterMarkTemplate> queryWaterMarkTemplateListResponse_waterMarkTemplateList = new List<QueryWaterMarkTemplateListResponse.QueryWaterMarkTemplateList_WaterMarkTemplate>();
			for (int i = 0; i < _ctx.Length("QueryWaterMarkTemplateList.WaterMarkTemplateList.Length"); i++) {
				QueryWaterMarkTemplateListResponse.QueryWaterMarkTemplateList_WaterMarkTemplate waterMarkTemplate = new QueryWaterMarkTemplateListResponse.QueryWaterMarkTemplateList_WaterMarkTemplate();
				waterMarkTemplate.Type = _ctx.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Type");
				waterMarkTemplate.ReferPos = _ctx.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].ReferPos");
				waterMarkTemplate.State = _ctx.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].State");
				waterMarkTemplate.Dx = _ctx.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Dx");
				waterMarkTemplate.Width = _ctx.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Width");
				waterMarkTemplate.Height = _ctx.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Height");
				waterMarkTemplate.Name = _ctx.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Name");
				waterMarkTemplate.Dy = _ctx.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Dy");
				waterMarkTemplate.Id = _ctx.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Id");

				QueryWaterMarkTemplateListResponse.QueryWaterMarkTemplateList_WaterMarkTemplate.QueryWaterMarkTemplateList_RatioRefer ratioRefer = new QueryWaterMarkTemplateListResponse.QueryWaterMarkTemplateList_WaterMarkTemplate.QueryWaterMarkTemplateList_RatioRefer();
				ratioRefer.Dx = _ctx.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].RatioRefer.Dx");
				ratioRefer.Width = _ctx.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].RatioRefer.Width");
				ratioRefer.Height = _ctx.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].RatioRefer.Height");
				ratioRefer.Dy = _ctx.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].RatioRefer.Dy");
				waterMarkTemplate.RatioRefer = ratioRefer;

				QueryWaterMarkTemplateListResponse.QueryWaterMarkTemplateList_WaterMarkTemplate.QueryWaterMarkTemplateList_Timeline timeline = new QueryWaterMarkTemplateListResponse.QueryWaterMarkTemplateList_WaterMarkTemplate.QueryWaterMarkTemplateList_Timeline();
				timeline.Start = _ctx.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Timeline.Start");
				timeline.Duration = _ctx.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Timeline.Duration");
				waterMarkTemplate.Timeline = timeline;

				queryWaterMarkTemplateListResponse_waterMarkTemplateList.Add(waterMarkTemplate);
			}
			queryWaterMarkTemplateListResponse.WaterMarkTemplateList = queryWaterMarkTemplateListResponse_waterMarkTemplateList;
        
			return queryWaterMarkTemplateListResponse;
        }
    }
}
