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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class UninstallLogstashPluginResponseUnmarshaller
    {
        public static UninstallLogstashPluginResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UninstallLogstashPluginResponse uninstallLogstashPluginResponse = new UninstallLogstashPluginResponse();

			uninstallLogstashPluginResponse.HttpResponse = _ctx.HttpResponse;
			uninstallLogstashPluginResponse.RequestId = _ctx.StringValue("UninstallLogstashPlugin.RequestId");
			uninstallLogstashPluginResponse.Headers = _ctx.StringValue("UninstallLogstashPlugin.Headers");

			List<string> uninstallLogstashPluginResponse_result = new List<string>();
			for (int i = 0; i < _ctx.Length("UninstallLogstashPlugin.Result.Length"); i++) {
				uninstallLogstashPluginResponse_result.Add(_ctx.StringValue("UninstallLogstashPlugin.Result["+ i +"]"));
			}
			uninstallLogstashPluginResponse.Result = uninstallLogstashPluginResponse_result;
        
			return uninstallLogstashPluginResponse;
        }
    }
}
