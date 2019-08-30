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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class ListChangeSetsResponseUnmarshaller
    {
        public static ListChangeSetsResponse Unmarshall(UnmarshallerContext context)
        {
			ListChangeSetsResponse listChangeSetsResponse = new ListChangeSetsResponse();

			listChangeSetsResponse.HttpResponse = context.HttpResponse;
			listChangeSetsResponse.PageNumber = context.IntegerValue("ListChangeSets.PageNumber");
			listChangeSetsResponse.PageSize = context.IntegerValue("ListChangeSets.PageSize");
			listChangeSetsResponse.RequestId = context.StringValue("ListChangeSets.RequestId");
			listChangeSetsResponse.TotalCount = context.IntegerValue("ListChangeSets.TotalCount");

			List<ListChangeSetsResponse.ListChangeSets_ChangeSet> listChangeSetsResponse_changeSets = new List<ListChangeSetsResponse.ListChangeSets_ChangeSet>();
			for (int i = 0; i < context.Length("ListChangeSets.ChangeSets.Length"); i++) {
				ListChangeSetsResponse.ListChangeSets_ChangeSet changeSet = new ListChangeSetsResponse.ListChangeSets_ChangeSet();
				changeSet.ChangeSetId = context.StringValue("ListChangeSets.ChangeSets["+ i +"].ChangeSetId");
				changeSet.ChangeSetName = context.StringValue("ListChangeSets.ChangeSets["+ i +"].ChangeSetName");
				changeSet.ChangeSetType = context.StringValue("ListChangeSets.ChangeSets["+ i +"].ChangeSetType");
				changeSet.CreateTime = context.StringValue("ListChangeSets.ChangeSets["+ i +"].CreateTime");
				changeSet.Description = context.StringValue("ListChangeSets.ChangeSets["+ i +"].Description");
				changeSet.ExecutionStatus = context.StringValue("ListChangeSets.ChangeSets["+ i +"].ExecutionStatus");
				changeSet.RegionId = context.StringValue("ListChangeSets.ChangeSets["+ i +"].RegionId");
				changeSet.StackId = context.StringValue("ListChangeSets.ChangeSets["+ i +"].StackId");
				changeSet.StackName = context.StringValue("ListChangeSets.ChangeSets["+ i +"].StackName");
				changeSet.Status = context.StringValue("ListChangeSets.ChangeSets["+ i +"].Status");

				listChangeSetsResponse_changeSets.Add(changeSet);
			}
			listChangeSetsResponse.ChangeSets = listChangeSetsResponse_changeSets;
        
			return listChangeSetsResponse;
        }
    }
}
