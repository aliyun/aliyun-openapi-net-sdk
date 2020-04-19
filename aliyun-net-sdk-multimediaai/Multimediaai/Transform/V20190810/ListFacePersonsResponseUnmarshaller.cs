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
    public class ListFacePersonsResponseUnmarshaller
    {
        public static ListFacePersonsResponse Unmarshall(UnmarshallerContext context)
        {
			ListFacePersonsResponse listFacePersonsResponse = new ListFacePersonsResponse();

			listFacePersonsResponse.HttpResponse = context.HttpResponse;
			listFacePersonsResponse.RequestId = context.StringValue("ListFacePersons.RequestId");
			listFacePersonsResponse.PageNumber = context.IntegerValue("ListFacePersons.PageNumber");
			listFacePersonsResponse.PageSize = context.IntegerValue("ListFacePersons.PageSize");
			listFacePersonsResponse.TotalCount = context.LongValue("ListFacePersons.TotalCount");

			List<ListFacePersonsResponse.ListFacePersons_FacePerson> listFacePersonsResponse_facePersons = new List<ListFacePersonsResponse.ListFacePersons_FacePerson>();
			for (int i = 0; i < context.Length("ListFacePersons.FacePersons.Length"); i++) {
				ListFacePersonsResponse.ListFacePersons_FacePerson facePerson = new ListFacePersonsResponse.ListFacePersons_FacePerson();
				facePerson.FacePersonId = context.LongValue("ListFacePersons.FacePersons["+ i +"].FacePersonId");
				facePerson.FacePersonName = context.StringValue("ListFacePersons.FacePersons["+ i +"].FacePersonName");
				facePerson.ImageUrl = context.StringValue("ListFacePersons.FacePersons["+ i +"].ImageUrl");
				facePerson.ImageCount = context.LongValue("ListFacePersons.FacePersons["+ i +"].ImageCount");

				listFacePersonsResponse_facePersons.Add(facePerson);
			}
			listFacePersonsResponse.FacePersons = listFacePersonsResponse_facePersons;
        
			return listFacePersonsResponse;
        }
    }
}
