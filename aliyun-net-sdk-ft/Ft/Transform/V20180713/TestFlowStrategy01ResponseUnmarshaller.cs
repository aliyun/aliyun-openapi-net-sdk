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
using Aliyun.Acs.Ft.Model.V20180713;

namespace Aliyun.Acs.Ft.Transform.V20180713
{
    public class TestFlowStrategy01ResponseUnmarshaller
    {
        public static TestFlowStrategy01Response Unmarshall(UnmarshallerContext _ctx)
        {
			TestFlowStrategy01Response testFlowStrategy01Response = new TestFlowStrategy01Response();

			testFlowStrategy01Response.HttpResponse = _ctx.HttpResponse;
			testFlowStrategy01Response.RequestId = _ctx.StringValue("TestFlowStrategy01.RequestId");

			List<string> testFlowStrategy01Response_list = new List<string>();
			for (int i = 0; i < _ctx.Length("TestFlowStrategy01.List.Length"); i++) {
				testFlowStrategy01Response_list.Add(_ctx.StringValue("TestFlowStrategy01.List["+ i +"]"));
			}
			testFlowStrategy01Response.List = testFlowStrategy01Response_list;

			List<string> testFlowStrategy01Response_names = new List<string>();
			for (int i = 0; i < _ctx.Length("TestFlowStrategy01.Names.Length"); i++) {
				testFlowStrategy01Response_names.Add(_ctx.StringValue("TestFlowStrategy01.Names["+ i +"]"));
			}
			testFlowStrategy01Response.Names = testFlowStrategy01Response_names;
        
			return testFlowStrategy01Response;
        }
    }
}
