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
using Aliyun.Acs.multimediaai.Model.V20190810;

namespace Aliyun.Acs.multimediaai.Transform.V20190810
{
    public class ListFaceGroupsResponseUnmarshaller
    {
        public static ListFaceGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			ListFaceGroupsResponse listFaceGroupsResponse = new ListFaceGroupsResponse();

			listFaceGroupsResponse.HttpResponse = context.HttpResponse;
			listFaceGroupsResponse.RequestId = context.StringValue("ListFaceGroups.RequestId");
			listFaceGroupsResponse.PageNumber = context.IntegerValue("ListFaceGroups.PageNumber");
			listFaceGroupsResponse.PageSize = context.IntegerValue("ListFaceGroups.PageSize");
			listFaceGroupsResponse.TotalCount = context.LongValue("ListFaceGroups.TotalCount");

			List<ListFaceGroupsResponse.ListFaceGroups_FaceGroup> listFaceGroupsResponse_faceGroups = new List<ListFaceGroupsResponse.ListFaceGroups_FaceGroup>();
			for (int i = 0; i < context.Length("ListFaceGroups.FaceGroups.Length"); i++) {
				ListFaceGroupsResponse.ListFaceGroups_FaceGroup faceGroup = new ListFaceGroupsResponse.ListFaceGroups_FaceGroup();
				faceGroup.FaceGroupId = context.LongValue("ListFaceGroups.FaceGroups["+ i +"].FaceGroupId");
				faceGroup.FaceGroupName = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].FaceGroupName");
				faceGroup.Description = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].Description");
				faceGroup.PersonCount = context.LongValue("ListFaceGroups.FaceGroups["+ i +"].PersonCount");
				faceGroup.ImageCount = context.LongValue("ListFaceGroups.FaceGroups["+ i +"].ImageCount");

				List<ListFaceGroupsResponse.ListFaceGroups_FaceGroup.ListFaceGroups_TemplatesItem> faceGroup_templates = new List<ListFaceGroupsResponse.ListFaceGroups_FaceGroup.ListFaceGroups_TemplatesItem>();
				for (int j = 0; j < context.Length("ListFaceGroups.FaceGroups["+ i +"].Templates.Length"); j++) {
					ListFaceGroupsResponse.ListFaceGroups_FaceGroup.ListFaceGroups_TemplatesItem templatesItem = new ListFaceGroupsResponse.ListFaceGroups_FaceGroup.ListFaceGroups_TemplatesItem();
					templatesItem.Id = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].Templates["+ j +"].Id");
					templatesItem.Name = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].Templates["+ j +"].Name");

					faceGroup_templates.Add(templatesItem);
				}
				faceGroup.Templates = faceGroup_templates;

				listFaceGroupsResponse_faceGroups.Add(faceGroup);
			}
			listFaceGroupsResponse.FaceGroups = listFaceGroupsResponse_faceGroups;
        
			return listFaceGroupsResponse;
        }
    }
}
