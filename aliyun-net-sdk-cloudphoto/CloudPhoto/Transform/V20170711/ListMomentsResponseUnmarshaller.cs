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
using Aliyun.Acs.CloudPhoto.Model.V20170711;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class ListMomentsResponseUnmarshaller
    {
        public static ListMomentsResponse Unmarshall(UnmarshallerContext context)
        {
			ListMomentsResponse listMomentsResponse = new ListMomentsResponse();

			listMomentsResponse.HttpResponse = context.HttpResponse;
			listMomentsResponse.Code = context.StringValue("ListMoments.Code");
			listMomentsResponse.Message = context.StringValue("ListMoments.Message");
			listMomentsResponse.NextCursor = context.StringValue("ListMoments.NextCursor");
			listMomentsResponse.TotalCount = context.IntegerValue("ListMoments.TotalCount");
			listMomentsResponse.RequestId = context.StringValue("ListMoments.RequestId");
			listMomentsResponse.Action = context.StringValue("ListMoments.Action");

			List<ListMomentsResponse.ListMoments_Moment> listMomentsResponse_moments = new List<ListMomentsResponse.ListMoments_Moment>();
			for (int i = 0; i < context.Length("ListMoments.Moments.Length"); i++) {
				ListMomentsResponse.ListMoments_Moment moment = new ListMomentsResponse.ListMoments_Moment();
				moment.Id = context.LongValue("ListMoments.Moments["+ i +"].Id");
				moment.IdStr = context.StringValue("ListMoments.Moments["+ i +"].IdStr");
				moment.LocationName = context.StringValue("ListMoments.Moments["+ i +"].LocationName");
				moment.PhotosCount = context.IntegerValue("ListMoments.Moments["+ i +"].PhotosCount");
				moment.State = context.StringValue("ListMoments.Moments["+ i +"].State");
				moment.TakenAt = context.LongValue("ListMoments.Moments["+ i +"].TakenAt");
				moment.Ctime = context.LongValue("ListMoments.Moments["+ i +"].Ctime");
				moment.Mtime = context.LongValue("ListMoments.Moments["+ i +"].Mtime");

				listMomentsResponse_moments.Add(moment);
			}
			listMomentsResponse.Moments = listMomentsResponse_moments;
        
			return listMomentsResponse;
        }
    }
}
