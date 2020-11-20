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
using Aliyun.Acs.imagerecog.Model.V20190930;

namespace Aliyun.Acs.imagerecog.Transform.V20190930
{
    public class RecognizeSceneResponseUnmarshaller
    {
        public static RecognizeSceneResponse Unmarshall(UnmarshallerContext context)
        {
			RecognizeSceneResponse recognizeSceneResponse = new RecognizeSceneResponse();

			recognizeSceneResponse.HttpResponse = context.HttpResponse;
			recognizeSceneResponse.RequestId = context.StringValue("RecognizeScene.RequestId");

			RecognizeSceneResponse.RecognizeScene_Data data = new RecognizeSceneResponse.RecognizeScene_Data();

			List<RecognizeSceneResponse.RecognizeScene_Data.RecognizeScene_Tag> data_tags = new List<RecognizeSceneResponse.RecognizeScene_Data.RecognizeScene_Tag>();
			for (int i = 0; i < context.Length("RecognizeScene.Data.Tags.Length"); i++) {
				RecognizeSceneResponse.RecognizeScene_Data.RecognizeScene_Tag tag = new RecognizeSceneResponse.RecognizeScene_Data.RecognizeScene_Tag();
				tag.Confidence = context.FloatValue("RecognizeScene.Data.Tags["+ i +"].Confidence");
				tag._Value = context.StringValue("RecognizeScene.Data.Tags["+ i +"].Value");

				data_tags.Add(tag);
			}
			data.Tags = data_tags;
			recognizeSceneResponse.Data = data;
        
			return recognizeSceneResponse;
        }
    }
}
