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
    public class RecognizeActionResponseUnmarshaller
    {
        public static RecognizeActionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeActionResponse recognizeActionResponse = new RecognizeActionResponse();

			recognizeActionResponse.HttpResponse = _ctx.HttpResponse;
			recognizeActionResponse.RequestId = _ctx.StringValue("RecognizeAction.RequestId");

			RecognizeActionResponse.RecognizeAction_Data data = new RecognizeActionResponse.RecognizeAction_Data();

			List<RecognizeActionResponse.RecognizeAction_Data.RecognizeAction_Element> data_elements = new List<RecognizeActionResponse.RecognizeAction_Data.RecognizeAction_Element>();
			for (int i = 0; i < _ctx.Length("RecognizeAction.Data.Elements.Length"); i++) {
				RecognizeActionResponse.RecognizeAction_Data.RecognizeAction_Element element = new RecognizeActionResponse.RecognizeAction_Data.RecognizeAction_Element();
				element.Timestamp = _ctx.IntegerValue("RecognizeAction.Data.Elements["+ i +"].Timestamp");

				List<string> element_scores = new List<string>();
				for (int j = 0; j < _ctx.Length("RecognizeAction.Data.Elements["+ i +"].Scores.Length"); j++) {
					element_scores.Add(_ctx.StringValue("RecognizeAction.Data.Elements["+ i +"].Scores["+ j +"]"));
				}
				element.Scores = element_scores;

				List<string> element_labels = new List<string>();
				for (int j = 0; j < _ctx.Length("RecognizeAction.Data.Elements["+ i +"].Labels.Length"); j++) {
					element_labels.Add(_ctx.StringValue("RecognizeAction.Data.Elements["+ i +"].Labels["+ j +"]"));
				}
				element.Labels = element_labels;

				List<RecognizeActionResponse.RecognizeAction_Data.RecognizeAction_Element.RecognizeAction_BoxesItem> element_boxes = new List<RecognizeActionResponse.RecognizeAction_Data.RecognizeAction_Element.RecognizeAction_BoxesItem>();
				for (int j = 0; j < _ctx.Length("RecognizeAction.Data.Elements["+ i +"].Boxes.Length"); j++) {
					RecognizeActionResponse.RecognizeAction_Data.RecognizeAction_Element.RecognizeAction_BoxesItem boxesItem = new RecognizeActionResponse.RecognizeAction_Data.RecognizeAction_Element.RecognizeAction_BoxesItem();

					List<string> boxesItem_box = new List<string>();
					for (int k = 0; k < _ctx.Length("RecognizeAction.Data.Elements["+ i +"].Boxes["+ j +"].Box.Length"); k++) {
						boxesItem_box.Add(_ctx.StringValue("RecognizeAction.Data.Elements["+ i +"].Boxes["+ j +"].Box["+ k +"]"));
					}
					boxesItem.Box = boxesItem_box;

					element_boxes.Add(boxesItem);
				}
				element.Boxes = element_boxes;

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			recognizeActionResponse.Data = data;
        
			return recognizeActionResponse;
        }
    }
}
