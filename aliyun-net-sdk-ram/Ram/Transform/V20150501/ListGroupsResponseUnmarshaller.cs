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
using Aliyun.Acs.Ram.Model.V20150501;

namespace Aliyun.Acs.Ram.Transform.V20150501
{
    public class ListGroupsResponseUnmarshaller
    {
        public static ListGroupsResponse Unmarshall(UnmarshallerContext context)
        {
            ListGroupsResponse listGroupsResponse = new ListGroupsResponse();

            listGroupsResponse.HttpResponse = context.HttpResponse;
            listGroupsResponse.RequestId = context.StringValue("ListGroups.RequestId");
            listGroupsResponse.IsTruncated = context.BooleanValue("ListGroups.IsTruncated");
            listGroupsResponse.Marker = context.StringValue("ListGroups.Marker");

            List<ListGroupsResponse.ListGroups_Group> listGroupsResponse_groups = new List<ListGroupsResponse.ListGroups_Group>();
            for (int i = 0; i < context.Length("ListGroups.Groups.Length"); i++)
            {
                ListGroupsResponse.ListGroups_Group group = new ListGroupsResponse.ListGroups_Group();
                group.GroupName = context.StringValue("ListGroups.Groups[" + i + "].GroupName");
                group.Comments = context.StringValue("ListGroups.Groups[" + i + "].Comments");
                group.CreateDate = context.StringValue("ListGroups.Groups[" + i + "].CreateDate");
                group.UpdateDate = context.StringValue("ListGroups.Groups[" + i + "].UpdateDate");

                listGroupsResponse_groups.Add(group);
            }
            listGroupsResponse.Groups = listGroupsResponse_groups;

            return listGroupsResponse;
        }
    }
}
