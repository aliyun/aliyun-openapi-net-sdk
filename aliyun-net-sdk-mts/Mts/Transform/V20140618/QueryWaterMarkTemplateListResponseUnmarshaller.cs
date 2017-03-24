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
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class QueryWaterMarkTemplateListResponseUnmarshaller
    {
        public static QueryWaterMarkTemplateListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryWaterMarkTemplateListResponse queryWaterMarkTemplateListResponse = new QueryWaterMarkTemplateListResponse();

			queryWaterMarkTemplateListResponse.HttpResponse = context.HttpResponse;
			queryWaterMarkTemplateListResponse.RequestId = context.StringValue("QueryWaterMarkTemplateList.RequestId");

			List<string> nonExistWids = new List<string>();
			for (int i = 0; i < context.Length("QueryWaterMarkTemplateList.NonExistWids.Length"); i++) {
				nonExistWids.Add(context.StringValue("QueryWaterMarkTemplateList.NonExistWids["+ i +"]"));
			}
			queryWaterMarkTemplateListResponse.NonExistWids = nonExistWids;

			List<QueryWaterMarkTemplateListResponse.WaterMarkTemplate> waterMarkTemplateList = new List<QueryWaterMarkTemplateListResponse.WaterMarkTemplate>();
			for (int i = 0; i < context.Length("QueryWaterMarkTemplateList.WaterMarkTemplateList.Length"); i++) {
				QueryWaterMarkTemplateListResponse.WaterMarkTemplate waterMarkTemplate = new QueryWaterMarkTemplateListResponse.WaterMarkTemplate();
				waterMarkTemplate.Id = context.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Id");
				waterMarkTemplate.Name = context.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Name");
				waterMarkTemplate.Width = context.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Width");
				waterMarkTemplate.Height = context.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Height");
				waterMarkTemplate.Dx = context.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Dx");
				waterMarkTemplate.Dy = context.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Dy");
				waterMarkTemplate.ReferPos = context.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].ReferPos");
				waterMarkTemplate.Type = context.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Type");
				waterMarkTemplate.State = context.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].State");

				QueryWaterMarkTemplateListResponse.WaterMarkTemplate.Timeline_ timeline = new QueryWaterMarkTemplateListResponse.WaterMarkTemplate.Timeline_();
				timeline.Start = context.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Timeline.Start");
				timeline.Duration = context.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].Timeline.Duration");
				waterMarkTemplate.Timeline = timeline;

				QueryWaterMarkTemplateListResponse.WaterMarkTemplate.RatioRefer_ ratioRefer = new QueryWaterMarkTemplateListResponse.WaterMarkTemplate.RatioRefer_();
				ratioRefer.Dx = context.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].RatioRefer.Dx");
				ratioRefer.Dy = context.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].RatioRefer.Dy");
				ratioRefer.Width = context.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].RatioRefer.Width");
				ratioRefer.Height = context.StringValue("QueryWaterMarkTemplateList.WaterMarkTemplateList["+ i +"].RatioRefer.Height");
				waterMarkTemplate.RatioRefer = ratioRefer;

				waterMarkTemplateList.Add(waterMarkTemplate);
			}
			queryWaterMarkTemplateListResponse.WaterMarkTemplateList = waterMarkTemplateList;
        
			return queryWaterMarkTemplateListResponse;
        }
    }
}