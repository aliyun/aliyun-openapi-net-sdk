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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListFaceGroupsResponseUnmarshaller
    {
        public static ListFaceGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFaceGroupsResponse listFaceGroupsResponse = new ListFaceGroupsResponse();

			listFaceGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listFaceGroupsResponse.RequestId = _ctx.StringValue("ListFaceGroups.RequestId");
			listFaceGroupsResponse.NextMarker = _ctx.StringValue("ListFaceGroups.NextMarker");

			List<ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem> listFaceGroupsResponse_faceGroups = new List<ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem>();
			for (int i = 0; i < _ctx.Length("ListFaceGroups.FaceGroups.Length"); i++) {
				ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem faceGroupsItem = new ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem();
				faceGroupsItem.GroupName = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].GroupName");
				faceGroupsItem.ModifyTime = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].ModifyTime");
				faceGroupsItem.ExternalId = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].ExternalId");
				faceGroupsItem.CreateTime = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].CreateTime");
				faceGroupsItem.MaxAge = _ctx.FloatValue("ListFaceGroups.FaceGroups["+ i +"].MaxAge");
				faceGroupsItem.Gender = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].Gender");
				faceGroupsItem.AverageAge = _ctx.FloatValue("ListFaceGroups.FaceGroups["+ i +"].AverageAge");
				faceGroupsItem.RemarksA = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksA");
				faceGroupsItem.RemarksB = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksB");
				faceGroupsItem.GroupId = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].GroupId");
				faceGroupsItem.RemarksArrayB = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksArrayB");
				faceGroupsItem.ImageCount = _ctx.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].ImageCount");
				faceGroupsItem.MinAge = _ctx.FloatValue("ListFaceGroups.FaceGroups["+ i +"].MinAge");
				faceGroupsItem.RemarksC = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksC");
				faceGroupsItem.RemarksD = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksD");
				faceGroupsItem.RemarksArrayA = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksArrayA");
				faceGroupsItem.FaceCount = _ctx.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].FaceCount");

				ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem.ListFaceGroups_GroupCoverFace groupCoverFace = new ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem.ListFaceGroups_GroupCoverFace();
				groupCoverFace.FaceId = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.FaceId");
				groupCoverFace.ImageHeight = _ctx.LongValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.ImageHeight");
				groupCoverFace.ImageWidth = _ctx.LongValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.ImageWidth");
				groupCoverFace.ExternalId = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.ExternalId");
				groupCoverFace.ImageUri = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.ImageUri");

				ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem.ListFaceGroups_GroupCoverFace.ListFaceGroups_FaceBoundary faceBoundary = new ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem.ListFaceGroups_GroupCoverFace.ListFaceGroups_FaceBoundary();
				faceBoundary.Left = _ctx.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.FaceBoundary.Left");
				faceBoundary.Top = _ctx.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.FaceBoundary.Top");
				faceBoundary.Height = _ctx.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.FaceBoundary.Height");
				faceBoundary.Width = _ctx.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.FaceBoundary.Width");
				groupCoverFace.FaceBoundary = faceBoundary;
				faceGroupsItem.GroupCoverFace = groupCoverFace;

				listFaceGroupsResponse_faceGroups.Add(faceGroupsItem);
			}
			listFaceGroupsResponse.FaceGroups = listFaceGroupsResponse_faceGroups;
        
			return listFaceGroupsResponse;
        }
    }
}
