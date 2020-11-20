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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class RemoveTerminalsResponseUnmarshaller
    {
        public static RemoveTerminalsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RemoveTerminalsResponse removeTerminalsResponse = new RemoveTerminalsResponse();

			removeTerminalsResponse.HttpResponse = _ctx.HttpResponse;
			removeTerminalsResponse.RequestId = _ctx.StringValue("RemoveTerminals.RequestId");

			List<RemoveTerminalsResponse.RemoveTerminals_Terminal> removeTerminalsResponse_terminals = new List<RemoveTerminalsResponse.RemoveTerminals_Terminal>();
			for (int i = 0; i < _ctx.Length("RemoveTerminals.Terminals.Length"); i++) {
				RemoveTerminalsResponse.RemoveTerminals_Terminal terminal = new RemoveTerminalsResponse.RemoveTerminals_Terminal();
				terminal.Id = _ctx.StringValue("RemoveTerminals.Terminals["+ i +"].Id");
				terminal.Code = _ctx.IntegerValue("RemoveTerminals.Terminals["+ i +"].Code");
				terminal.Message = _ctx.StringValue("RemoveTerminals.Terminals["+ i +"].Message");

				removeTerminalsResponse_terminals.Add(terminal);
			}
			removeTerminalsResponse.Terminals = removeTerminalsResponse_terminals;
        
			return removeTerminalsResponse;
        }
    }
}
