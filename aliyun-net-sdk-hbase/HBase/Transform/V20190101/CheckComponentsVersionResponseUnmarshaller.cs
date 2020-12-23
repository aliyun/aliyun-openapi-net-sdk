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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class CheckComponentsVersionResponseUnmarshaller
    {
        public static CheckComponentsVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckComponentsVersionResponse checkComponentsVersionResponse = new CheckComponentsVersionResponse();

			checkComponentsVersionResponse.HttpResponse = _ctx.HttpResponse;
			checkComponentsVersionResponse.RequestId = _ctx.StringValue("CheckComponentsVersion.RequestId");

			List<CheckComponentsVersionResponse.CheckComponentsVersion_Component> checkComponentsVersionResponse_components = new List<CheckComponentsVersionResponse.CheckComponentsVersion_Component>();
			for (int i = 0; i < _ctx.Length("CheckComponentsVersion.Components.Length"); i++) {
				CheckComponentsVersionResponse.CheckComponentsVersion_Component component = new CheckComponentsVersionResponse.CheckComponentsVersion_Component();
				component.Component = _ctx.StringValue("CheckComponentsVersion.Components["+ i +"].Component");
				component.IsLatestVersion = _ctx.StringValue("CheckComponentsVersion.Components["+ i +"].IsLatestVersion");

				checkComponentsVersionResponse_components.Add(component);
			}
			checkComponentsVersionResponse.Components = checkComponentsVersionResponse_components;
        
			return checkComponentsVersionResponse;
        }
    }
}
