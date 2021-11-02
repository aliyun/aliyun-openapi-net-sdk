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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class ListDetectionTemplateResponseUnmarshaller
    {
        public static ListDetectionTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDetectionTemplateResponse listDetectionTemplateResponse = new ListDetectionTemplateResponse();

			listDetectionTemplateResponse.HttpResponse = _ctx.HttpResponse;
			listDetectionTemplateResponse.RequestId = _ctx.StringValue("ListDetectionTemplate.RequestId");

			List<ListDetectionTemplateResponse.ListDetectionTemplate_DetectionTemplate> listDetectionTemplateResponse_detectionTemplateList = new List<ListDetectionTemplateResponse.ListDetectionTemplate_DetectionTemplate>();
			for (int i = 0; i < _ctx.Length("ListDetectionTemplate.DetectionTemplateList.Length"); i++) {
				ListDetectionTemplateResponse.ListDetectionTemplate_DetectionTemplate detectionTemplate = new ListDetectionTemplateResponse.ListDetectionTemplate_DetectionTemplate();
				detectionTemplate.CreateTime = _ctx.StringValue("ListDetectionTemplate.DetectionTemplateList["+ i +"].CreateTime");
				detectionTemplate.UserId = _ctx.LongValue("ListDetectionTemplate.DetectionTemplateList["+ i +"].UserId");
				detectionTemplate.TemplateName = _ctx.StringValue("ListDetectionTemplate.DetectionTemplateList["+ i +"].TemplateName");
				detectionTemplate.Period = _ctx.StringValue("ListDetectionTemplate.DetectionTemplateList["+ i +"].Period");
				detectionTemplate.Platform = _ctx.StringValue("ListDetectionTemplate.DetectionTemplateList["+ i +"].Platform");
				detectionTemplate.TemplateId = _ctx.StringValue("ListDetectionTemplate.DetectionTemplateList["+ i +"].TemplateId");
				detectionTemplate.ModifyTime = _ctx.StringValue("ListDetectionTemplate.DetectionTemplateList["+ i +"].ModifyTime");

				listDetectionTemplateResponse_detectionTemplateList.Add(detectionTemplate);
			}
			listDetectionTemplateResponse.DetectionTemplateList = listDetectionTemplateResponse_detectionTemplateList;
        
			return listDetectionTemplateResponse;
        }
    }
}
