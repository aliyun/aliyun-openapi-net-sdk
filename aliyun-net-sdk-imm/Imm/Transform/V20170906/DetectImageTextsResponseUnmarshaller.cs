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
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class DetectImageTextsResponseUnmarshaller
    {
        public static DetectImageTextsResponse Unmarshall(UnmarshallerContext context)
        {
			DetectImageTextsResponse detectImageTextsResponse = new DetectImageTextsResponse();

			detectImageTextsResponse.HttpResponse = context.HttpResponse;
			detectImageTextsResponse.RequestId = context.StringValue("DetectImageTexts.RequestId");
			detectImageTextsResponse.ImageUri = context.StringValue("DetectImageTexts.ImageUri");

			List<DetectImageTextsResponse.DetectImageTexts_OCRItem> detectImageTextsResponse_oCR = new List<DetectImageTextsResponse.DetectImageTexts_OCRItem>();
			for (int i = 0; i < context.Length("DetectImageTexts.OCR.Length"); i++) {
				DetectImageTextsResponse.DetectImageTexts_OCRItem oCRItem = new DetectImageTextsResponse.DetectImageTexts_OCRItem();
				oCRItem.OCRContents = context.StringValue("DetectImageTexts.OCR["+ i +"].OCRContents");
				oCRItem.OCRConfidence = context.FloatValue("DetectImageTexts.OCR["+ i +"].OCRConfidence");

				DetectImageTextsResponse.DetectImageTexts_OCRItem.DetectImageTexts_OCRBoundary oCRBoundary = new DetectImageTextsResponse.DetectImageTexts_OCRItem.DetectImageTexts_OCRBoundary();
				oCRBoundary.Left = context.IntegerValue("DetectImageTexts.OCR["+ i +"].OCRBoundary.Left");
				oCRBoundary.Top = context.IntegerValue("DetectImageTexts.OCR["+ i +"].OCRBoundary.Top");
				oCRBoundary.Width = context.IntegerValue("DetectImageTexts.OCR["+ i +"].OCRBoundary.Width");
				oCRBoundary.Height = context.IntegerValue("DetectImageTexts.OCR["+ i +"].OCRBoundary.Height");
				oCRItem.OCRBoundary = oCRBoundary;

				detectImageTextsResponse_oCR.Add(oCRItem);
			}
			detectImageTextsResponse.OCR = detectImageTextsResponse_oCR;
        
			return detectImageTextsResponse;
        }
    }
}