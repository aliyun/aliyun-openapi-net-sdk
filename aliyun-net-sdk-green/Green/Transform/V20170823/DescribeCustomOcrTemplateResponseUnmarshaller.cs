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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeCustomOcrTemplateResponseUnmarshaller
    {
        public static DescribeCustomOcrTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCustomOcrTemplateResponse describeCustomOcrTemplateResponse = new DescribeCustomOcrTemplateResponse();

			describeCustomOcrTemplateResponse.HttpResponse = _ctx.HttpResponse;
			describeCustomOcrTemplateResponse.RequestId = _ctx.StringValue("DescribeCustomOcrTemplate.RequestId");
			describeCustomOcrTemplateResponse.TotalCount = _ctx.IntegerValue("DescribeCustomOcrTemplate.TotalCount");

			List<DescribeCustomOcrTemplateResponse.DescribeCustomOcrTemplate_OcrTemplate> describeCustomOcrTemplateResponse_ocrTemplateList = new List<DescribeCustomOcrTemplateResponse.DescribeCustomOcrTemplate_OcrTemplate>();
			for (int i = 0; i < _ctx.Length("DescribeCustomOcrTemplate.OcrTemplateList.Length"); i++) {
				DescribeCustomOcrTemplateResponse.DescribeCustomOcrTemplate_OcrTemplate ocrTemplate = new DescribeCustomOcrTemplateResponse.DescribeCustomOcrTemplate_OcrTemplate();
				ocrTemplate.Id = _ctx.LongValue("DescribeCustomOcrTemplate.OcrTemplateList["+ i +"].Id");
				ocrTemplate.Name = _ctx.StringValue("DescribeCustomOcrTemplate.OcrTemplateList["+ i +"].Name");
				ocrTemplate.ImgUrl = _ctx.StringValue("DescribeCustomOcrTemplate.OcrTemplateList["+ i +"].ImgUrl");
				ocrTemplate.Status = _ctx.IntegerValue("DescribeCustomOcrTemplate.OcrTemplateList["+ i +"].Status");

				List<DescribeCustomOcrTemplateResponse.DescribeCustomOcrTemplate_OcrTemplate.DescribeCustomOcrTemplate_Item> ocrTemplate_referArea = new List<DescribeCustomOcrTemplateResponse.DescribeCustomOcrTemplate_OcrTemplate.DescribeCustomOcrTemplate_Item>();
				for (int j = 0; j < _ctx.Length("DescribeCustomOcrTemplate.OcrTemplateList["+ i +"].ReferArea.Length"); j++) {
					DescribeCustomOcrTemplateResponse.DescribeCustomOcrTemplate_OcrTemplate.DescribeCustomOcrTemplate_Item item = new DescribeCustomOcrTemplateResponse.DescribeCustomOcrTemplate_OcrTemplate.DescribeCustomOcrTemplate_Item();
					item.Name = _ctx.StringValue("DescribeCustomOcrTemplate.OcrTemplateList["+ i +"].ReferArea["+ j +"].Name");
					item.X = _ctx.IntegerValue("DescribeCustomOcrTemplate.OcrTemplateList["+ i +"].ReferArea["+ j +"].X");
					item.Y = _ctx.IntegerValue("DescribeCustomOcrTemplate.OcrTemplateList["+ i +"].ReferArea["+ j +"].Y");
					item.Width = _ctx.IntegerValue("DescribeCustomOcrTemplate.OcrTemplateList["+ i +"].ReferArea["+ j +"].Width");
					item.Height = _ctx.IntegerValue("DescribeCustomOcrTemplate.OcrTemplateList["+ i +"].ReferArea["+ j +"].Height");

					ocrTemplate_referArea.Add(item);
				}
				ocrTemplate.ReferArea = ocrTemplate_referArea;

				List<DescribeCustomOcrTemplateResponse.DescribeCustomOcrTemplate_OcrTemplate.DescribeCustomOcrTemplate_Item> ocrTemplate_recognizeArea = new List<DescribeCustomOcrTemplateResponse.DescribeCustomOcrTemplate_OcrTemplate.DescribeCustomOcrTemplate_Item>();
				for (int j = 0; j < _ctx.Length("DescribeCustomOcrTemplate.OcrTemplateList["+ i +"].RecognizeArea.Length"); j++) {
					DescribeCustomOcrTemplateResponse.DescribeCustomOcrTemplate_OcrTemplate.DescribeCustomOcrTemplate_Item item = new DescribeCustomOcrTemplateResponse.DescribeCustomOcrTemplate_OcrTemplate.DescribeCustomOcrTemplate_Item();
					item.Name = _ctx.StringValue("DescribeCustomOcrTemplate.OcrTemplateList["+ i +"].RecognizeArea["+ j +"].Name");
					item.X = _ctx.IntegerValue("DescribeCustomOcrTemplate.OcrTemplateList["+ i +"].RecognizeArea["+ j +"].X");
					item.Y = _ctx.IntegerValue("DescribeCustomOcrTemplate.OcrTemplateList["+ i +"].RecognizeArea["+ j +"].Y");
					item.Width = _ctx.IntegerValue("DescribeCustomOcrTemplate.OcrTemplateList["+ i +"].RecognizeArea["+ j +"].Width");
					item.Height = _ctx.IntegerValue("DescribeCustomOcrTemplate.OcrTemplateList["+ i +"].RecognizeArea["+ j +"].Height");

					ocrTemplate_recognizeArea.Add(item);
				}
				ocrTemplate.RecognizeArea = ocrTemplate_recognizeArea;

				describeCustomOcrTemplateResponse_ocrTemplateList.Add(ocrTemplate);
			}
			describeCustomOcrTemplateResponse.OcrTemplateList = describeCustomOcrTemplateResponse_ocrTemplateList;
        
			return describeCustomOcrTemplateResponse;
        }
    }
}
