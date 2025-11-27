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
    public class AddWaterMarkTemplateResponseUnmarshaller
    {
        public static AddWaterMarkTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddWaterMarkTemplateResponse addWaterMarkTemplateResponse = new AddWaterMarkTemplateResponse();

			addWaterMarkTemplateResponse.HttpResponse = _ctx.HttpResponse;
			addWaterMarkTemplateResponse.RequestId = _ctx.StringValue("AddWaterMarkTemplate.RequestId");

			AddWaterMarkTemplateResponse.AddWaterMarkTemplate_WaterMarkTemplate waterMarkTemplate = new AddWaterMarkTemplateResponse.AddWaterMarkTemplate_WaterMarkTemplate();
			waterMarkTemplate.Type = _ctx.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.Type");
			waterMarkTemplate.ReferPos = _ctx.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.ReferPos");
			waterMarkTemplate.State = _ctx.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.State");
			waterMarkTemplate.Dx = _ctx.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.Dx");
			waterMarkTemplate.Width = _ctx.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.Width");
			waterMarkTemplate.Height = _ctx.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.Height");
			waterMarkTemplate.Name = _ctx.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.Name");
			waterMarkTemplate.Dy = _ctx.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.Dy");
			waterMarkTemplate.Id = _ctx.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.Id");

			AddWaterMarkTemplateResponse.AddWaterMarkTemplate_WaterMarkTemplate.AddWaterMarkTemplate_RatioRefer ratioRefer = new AddWaterMarkTemplateResponse.AddWaterMarkTemplate_WaterMarkTemplate.AddWaterMarkTemplate_RatioRefer();
			ratioRefer.Dx = _ctx.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.RatioRefer.Dx");
			ratioRefer.Width = _ctx.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.RatioRefer.Width");
			ratioRefer.Height = _ctx.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.RatioRefer.Height");
			ratioRefer.Dy = _ctx.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.RatioRefer.Dy");
			waterMarkTemplate.RatioRefer = ratioRefer;

			AddWaterMarkTemplateResponse.AddWaterMarkTemplate_WaterMarkTemplate.AddWaterMarkTemplate_Timeline timeline = new AddWaterMarkTemplateResponse.AddWaterMarkTemplate_WaterMarkTemplate.AddWaterMarkTemplate_Timeline();
			timeline.Start = _ctx.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.Timeline.Start");
			timeline.Duration = _ctx.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.Timeline.Duration");
			waterMarkTemplate.Timeline = timeline;
			addWaterMarkTemplateResponse.WaterMarkTemplate = waterMarkTemplate;
        
			return addWaterMarkTemplateResponse;
        }
    }
}
