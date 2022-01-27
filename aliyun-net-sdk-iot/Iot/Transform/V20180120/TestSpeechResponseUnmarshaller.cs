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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class TestSpeechResponseUnmarshaller
    {
        public static TestSpeechResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TestSpeechResponse testSpeechResponse = new TestSpeechResponse();

			testSpeechResponse.HttpResponse = _ctx.HttpResponse;
			testSpeechResponse.RequestId = _ctx.StringValue("TestSpeech.RequestId");
			testSpeechResponse.Success = _ctx.BooleanValue("TestSpeech.Success");
			testSpeechResponse.Code = _ctx.StringValue("TestSpeech.Code");
			testSpeechResponse.ErrorMessage = _ctx.StringValue("TestSpeech.ErrorMessage");

			List<string> testSpeechResponse_data = new List<string>();
			for (int i = 0; i < _ctx.Length("TestSpeech.Data.Length"); i++) {
				testSpeechResponse_data.Add(_ctx.StringValue("TestSpeech.Data["+ i +"]"));
			}
			testSpeechResponse.Data = testSpeechResponse_data;
        
			return testSpeechResponse;
        }
    }
}
