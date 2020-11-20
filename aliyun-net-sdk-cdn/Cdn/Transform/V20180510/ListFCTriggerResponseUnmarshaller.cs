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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class ListFCTriggerResponseUnmarshaller
    {
        public static ListFCTriggerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFCTriggerResponse listFCTriggerResponse = new ListFCTriggerResponse();

			listFCTriggerResponse.HttpResponse = _ctx.HttpResponse;
			listFCTriggerResponse.RequestId = _ctx.StringValue("ListFCTrigger.RequestId");

			List<ListFCTriggerResponse.ListFCTrigger_FCTrigger> listFCTriggerResponse_fCTriggers = new List<ListFCTriggerResponse.ListFCTrigger_FCTrigger>();
			for (int i = 0; i < _ctx.Length("ListFCTrigger.FCTriggers.Length"); i++) {
				ListFCTriggerResponse.ListFCTrigger_FCTrigger fCTrigger = new ListFCTriggerResponse.ListFCTrigger_FCTrigger();
				fCTrigger.EventMetaName = _ctx.StringValue("ListFCTrigger.FCTriggers["+ i +"].EventMetaName");
				fCTrigger.EventMetaVersion = _ctx.StringValue("ListFCTrigger.FCTriggers["+ i +"].EventMetaVersion");
				fCTrigger.TriggerARN = _ctx.StringValue("ListFCTrigger.FCTriggers["+ i +"].TriggerARN");
				fCTrigger.RoleARN = _ctx.StringValue("ListFCTrigger.FCTriggers["+ i +"].RoleARN");
				fCTrigger.SourceArn = _ctx.StringValue("ListFCTrigger.FCTriggers["+ i +"].SourceArn");
				fCTrigger.Notes = _ctx.StringValue("ListFCTrigger.FCTriggers["+ i +"].Notes");

				listFCTriggerResponse_fCTriggers.Add(fCTrigger);
			}
			listFCTriggerResponse.FCTriggers = listFCTriggerResponse_fCTriggers;
        
			return listFCTriggerResponse;
        }
    }
}
