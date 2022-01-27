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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class ListActionsResponseUnmarshaller
    {
        public static ListActionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListActionsResponse listActionsResponse = new ListActionsResponse();

			listActionsResponse.HttpResponse = _ctx.HttpResponse;
			listActionsResponse.RequestId = _ctx.StringValue("ListActions.RequestId");
			listActionsResponse.MaxResults = _ctx.IntegerValue("ListActions.MaxResults");
			listActionsResponse.NextToken = _ctx.StringValue("ListActions.NextToken");

			List<ListActionsResponse.ListActions_Action> listActionsResponse_actions = new List<ListActionsResponse.ListActions_Action>();
			for (int i = 0; i < _ctx.Length("ListActions.Actions.Length"); i++) {
				ListActionsResponse.ListActions_Action action = new ListActionsResponse.ListActions_Action();
				action.OOSActionName = _ctx.StringValue("ListActions.Actions["+ i +"].OOSActionName");
				action.Description = _ctx.StringValue("ListActions.Actions["+ i +"].Description");
				action.ActionType = _ctx.StringValue("ListActions.Actions["+ i +"].ActionType");
				action.CreatedDate = _ctx.StringValue("ListActions.Actions["+ i +"].CreatedDate");
				action.Properties = _ctx.StringValue("ListActions.Actions["+ i +"].Properties");
				action.TemplateVersion = _ctx.StringValue("ListActions.Actions["+ i +"].TemplateVersion");

				listActionsResponse_actions.Add(action);
			}
			listActionsResponse.Actions = listActionsResponse_actions;
        
			return listActionsResponse;
        }
    }
}
