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
    public class UpdateWaterMarkTemplateResponseUnmarshaller
    {
        public static UpdateWaterMarkTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateWaterMarkTemplateResponse updateWaterMarkTemplateResponse = new UpdateWaterMarkTemplateResponse();

			updateWaterMarkTemplateResponse.HttpResponse = _ctx.HttpResponse;
			updateWaterMarkTemplateResponse.RequestId = _ctx.StringValue("UpdateWaterMarkTemplate.RequestId");

			UpdateWaterMarkTemplateResponse.UpdateWaterMarkTemplate_WaterMarkTemplate waterMarkTemplate = new UpdateWaterMarkTemplateResponse.UpdateWaterMarkTemplate_WaterMarkTemplate();
			waterMarkTemplate.Type = _ctx.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Type");
			waterMarkTemplate.ReferPos = _ctx.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.ReferPos");
			waterMarkTemplate.State = _ctx.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.State");
			waterMarkTemplate.Dx = _ctx.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Dx");
			waterMarkTemplate.Width = _ctx.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Width");
			waterMarkTemplate.Height = _ctx.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Height");
			waterMarkTemplate.Name = _ctx.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Name");
			waterMarkTemplate.Dy = _ctx.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Dy");
			waterMarkTemplate.Id = _ctx.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Id");

			UpdateWaterMarkTemplateResponse.UpdateWaterMarkTemplate_WaterMarkTemplate.UpdateWaterMarkTemplate_RatioRefer ratioRefer = new UpdateWaterMarkTemplateResponse.UpdateWaterMarkTemplate_WaterMarkTemplate.UpdateWaterMarkTemplate_RatioRefer();
			ratioRefer.Dx = _ctx.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.RatioRefer.Dx");
			ratioRefer.Width = _ctx.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.RatioRefer.Width");
			ratioRefer.Height = _ctx.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.RatioRefer.Height");
			ratioRefer.Dy = _ctx.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.RatioRefer.Dy");
			waterMarkTemplate.RatioRefer = ratioRefer;

			UpdateWaterMarkTemplateResponse.UpdateWaterMarkTemplate_WaterMarkTemplate.UpdateWaterMarkTemplate_Timeline timeline = new UpdateWaterMarkTemplateResponse.UpdateWaterMarkTemplate_WaterMarkTemplate.UpdateWaterMarkTemplate_Timeline();
			timeline.Start = _ctx.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Timeline.Start");
			timeline.Duration = _ctx.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Timeline.Duration");
			waterMarkTemplate.Timeline = timeline;
			updateWaterMarkTemplateResponse.WaterMarkTemplate = waterMarkTemplate;
        
			return updateWaterMarkTemplateResponse;
        }
    }
}
