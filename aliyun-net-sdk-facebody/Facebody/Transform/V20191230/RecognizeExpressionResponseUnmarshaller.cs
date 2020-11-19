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
using Aliyun.Acs.facebody.Model.V20191230;

namespace Aliyun.Acs.facebody.Transform.V20191230
{
    public class RecognizeExpressionResponseUnmarshaller
    {
        public static RecognizeExpressionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeExpressionResponse recognizeExpressionResponse = new RecognizeExpressionResponse();

			recognizeExpressionResponse.HttpResponse = _ctx.HttpResponse;
			recognizeExpressionResponse.RequestId = _ctx.StringValue("RecognizeExpression.RequestId");

			RecognizeExpressionResponse.RecognizeExpression_Data data = new RecognizeExpressionResponse.RecognizeExpression_Data();

			List<RecognizeExpressionResponse.RecognizeExpression_Data.RecognizeExpression_Element> data_elements = new List<RecognizeExpressionResponse.RecognizeExpression_Data.RecognizeExpression_Element>();
			for (int i = 0; i < _ctx.Length("RecognizeExpression.Data.Elements.Length"); i++) {
				RecognizeExpressionResponse.RecognizeExpression_Data.RecognizeExpression_Element element = new RecognizeExpressionResponse.RecognizeExpression_Data.RecognizeExpression_Element();
				element.Expression = _ctx.StringValue("RecognizeExpression.Data.Elements["+ i +"].Expression");
				element.FaceProbability = _ctx.FloatValue("RecognizeExpression.Data.Elements["+ i +"].FaceProbability");

				RecognizeExpressionResponse.RecognizeExpression_Data.RecognizeExpression_Element.RecognizeExpression_FaceRectangle faceRectangle = new RecognizeExpressionResponse.RecognizeExpression_Data.RecognizeExpression_Element.RecognizeExpression_FaceRectangle();
				faceRectangle.Height = _ctx.IntegerValue("RecognizeExpression.Data.Elements["+ i +"].FaceRectangle.Height");
				faceRectangle.Left = _ctx.IntegerValue("RecognizeExpression.Data.Elements["+ i +"].FaceRectangle.Left");
				faceRectangle.Top = _ctx.IntegerValue("RecognizeExpression.Data.Elements["+ i +"].FaceRectangle.Top");
				faceRectangle.Width = _ctx.IntegerValue("RecognizeExpression.Data.Elements["+ i +"].FaceRectangle.Width");
				element.FaceRectangle = faceRectangle;

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			recognizeExpressionResponse.Data = data;
        
			return recognizeExpressionResponse;
        }
    }
}
