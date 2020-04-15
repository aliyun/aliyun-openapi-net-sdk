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
using Aliyun.Acs.visionai_poc.Model.V20200408;

namespace Aliyun.Acs.visionai_poc.Transform.V20200408
{
    public class RecognizeLabelResponseUnmarshaller
    {
        public static RecognizeLabelResponse Unmarshall(UnmarshallerContext context)
        {
			RecognizeLabelResponse recognizeLabelResponse = new RecognizeLabelResponse();

			recognizeLabelResponse.HttpResponse = context.HttpResponse;
			recognizeLabelResponse.Code = context.StringValue("RecognizeLabel.Code");
			recognizeLabelResponse.Success = context.BooleanValue("RecognizeLabel.Success");
			recognizeLabelResponse.Message = context.StringValue("RecognizeLabel.Message");

			RecognizeLabelResponse.RecognizeLabel_Response response = new RecognizeLabelResponse.RecognizeLabel_Response();
			response.Success = context.BooleanValue("RecognizeLabel.Response.Success");
			response.Url = context.StringValue("RecognizeLabel.Response.Url");
			response.RequestId = context.StringValue("RecognizeLabel.Response.RequestId");
			response.ErrorCode = context.StringValue("RecognizeLabel.Response.ErrorCode");
			response.ErrorMessage = context.StringValue("RecognizeLabel.Response.ErrorMessage");

			RecognizeLabelResponse.RecognizeLabel_Response.RecognizeLabel_Data data = new RecognizeLabelResponse.RecognizeLabel_Response.RecognizeLabel_Data();

			List<RecognizeLabelResponse.RecognizeLabel_Response.RecognizeLabel_Data.RecognizeLabel_Node> data_objects = new List<RecognizeLabelResponse.RecognizeLabel_Response.RecognizeLabel_Data.RecognizeLabel_Node>();
			for (int i = 0; i < context.Length("RecognizeLabel.Response.Data.Objects.Length"); i++) {
				RecognizeLabelResponse.RecognizeLabel_Response.RecognizeLabel_Data.RecognizeLabel_Node node = new RecognizeLabelResponse.RecognizeLabel_Response.RecognizeLabel_Data.RecognizeLabel_Node();

				RecognizeLabelResponse.RecognizeLabel_Response.RecognizeLabel_Data.RecognizeLabel_Node.RecognizeLabel_PropertiesResults propertiesResults = new RecognizeLabelResponse.RecognizeLabel_Response.RecognizeLabel_Data.RecognizeLabel_Node.RecognizeLabel_PropertiesResults();
				propertiesResults.PropertyId = context.StringValue("RecognizeLabel.Response.Data.Objects["+ i +"].PropertiesResults.PropertyId");
				propertiesResults.PropertyName = context.StringValue("RecognizeLabel.Response.Data.Objects["+ i +"].PropertiesResults.PropertyName");

				List<RecognizeLabelResponse.RecognizeLabel_Response.RecognizeLabel_Data.RecognizeLabel_Node.RecognizeLabel_PropertiesResults.RecognizeLabel_SubNode> propertiesResults_values = new List<RecognizeLabelResponse.RecognizeLabel_Response.RecognizeLabel_Data.RecognizeLabel_Node.RecognizeLabel_PropertiesResults.RecognizeLabel_SubNode>();
				for (int j = 0; j < context.Length("RecognizeLabel.Response.Data.Objects["+ i +"].PropertiesResults.Values.Length"); j++) {
					RecognizeLabelResponse.RecognizeLabel_Response.RecognizeLabel_Data.RecognizeLabel_Node.RecognizeLabel_PropertiesResults.RecognizeLabel_SubNode subNode = new RecognizeLabelResponse.RecognizeLabel_Response.RecognizeLabel_Data.RecognizeLabel_Node.RecognizeLabel_PropertiesResults.RecognizeLabel_SubNode();
					subNode.Probability = context.IntegerValue("RecognizeLabel.Response.Data.Objects["+ i +"].PropertiesResults.Values["+ j +"].Probability");
					subNode.ValueId = context.StringValue("RecognizeLabel.Response.Data.Objects["+ i +"].PropertiesResults.Values["+ j +"].ValueId");
					subNode.ValueName = context.StringValue("RecognizeLabel.Response.Data.Objects["+ i +"].PropertiesResults.Values["+ j +"].ValueName");

					propertiesResults_values.Add(subNode);
				}
				propertiesResults.Values = propertiesResults_values;
				node.PropertiesResults = propertiesResults;

				data_objects.Add(node);
			}
			data.Objects = data_objects;
			response.Data = data;
			recognizeLabelResponse.Response = response;
        
			return recognizeLabelResponse;
        }
    }
}
