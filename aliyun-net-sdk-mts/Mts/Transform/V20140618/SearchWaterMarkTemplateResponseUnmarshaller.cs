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
    public class SearchWaterMarkTemplateResponseUnmarshaller
    {
        public static SearchWaterMarkTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchWaterMarkTemplateResponse searchWaterMarkTemplateResponse = new SearchWaterMarkTemplateResponse();

			searchWaterMarkTemplateResponse.HttpResponse = _ctx.HttpResponse;
			searchWaterMarkTemplateResponse.TotalCount = _ctx.LongValue("SearchWaterMarkTemplate.TotalCount");
			searchWaterMarkTemplateResponse.PageSize = _ctx.LongValue("SearchWaterMarkTemplate.PageSize");
			searchWaterMarkTemplateResponse.RequestId = _ctx.StringValue("SearchWaterMarkTemplate.RequestId");
			searchWaterMarkTemplateResponse.PageNumber = _ctx.LongValue("SearchWaterMarkTemplate.PageNumber");

			List<SearchWaterMarkTemplateResponse.SearchWaterMarkTemplate_WaterMarkTemplate> searchWaterMarkTemplateResponse_waterMarkTemplateList = new List<SearchWaterMarkTemplateResponse.SearchWaterMarkTemplate_WaterMarkTemplate>();
			for (int i = 0; i < _ctx.Length("SearchWaterMarkTemplate.WaterMarkTemplateList.Length"); i++) {
				SearchWaterMarkTemplateResponse.SearchWaterMarkTemplate_WaterMarkTemplate waterMarkTemplate = new SearchWaterMarkTemplateResponse.SearchWaterMarkTemplate_WaterMarkTemplate();
				waterMarkTemplate.Type = _ctx.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Type");
				waterMarkTemplate.ReferPos = _ctx.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].ReferPos");
				waterMarkTemplate.State = _ctx.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].State");
				waterMarkTemplate.Dx = _ctx.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Dx");
				waterMarkTemplate.Width = _ctx.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Width");
				waterMarkTemplate.Height = _ctx.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Height");
				waterMarkTemplate.Name = _ctx.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Name");
				waterMarkTemplate.Dy = _ctx.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Dy");
				waterMarkTemplate.Id = _ctx.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Id");

				SearchWaterMarkTemplateResponse.SearchWaterMarkTemplate_WaterMarkTemplate.SearchWaterMarkTemplate_RatioRefer ratioRefer = new SearchWaterMarkTemplateResponse.SearchWaterMarkTemplate_WaterMarkTemplate.SearchWaterMarkTemplate_RatioRefer();
				ratioRefer.Dx = _ctx.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].RatioRefer.Dx");
				ratioRefer.Width = _ctx.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].RatioRefer.Width");
				ratioRefer.Height = _ctx.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].RatioRefer.Height");
				ratioRefer.Dy = _ctx.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].RatioRefer.Dy");
				waterMarkTemplate.RatioRefer = ratioRefer;

				SearchWaterMarkTemplateResponse.SearchWaterMarkTemplate_WaterMarkTemplate.SearchWaterMarkTemplate_Timeline timeline = new SearchWaterMarkTemplateResponse.SearchWaterMarkTemplate_WaterMarkTemplate.SearchWaterMarkTemplate_Timeline();
				timeline.Start = _ctx.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Timeline.Start");
				timeline.Duration = _ctx.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Timeline.Duration");
				waterMarkTemplate.Timeline = timeline;

				searchWaterMarkTemplateResponse_waterMarkTemplateList.Add(waterMarkTemplate);
			}
			searchWaterMarkTemplateResponse.WaterMarkTemplateList = searchWaterMarkTemplateResponse_waterMarkTemplateList;
        
			return searchWaterMarkTemplateResponse;
        }
    }
}
