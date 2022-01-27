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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class ListPersonDetailsResponseUnmarshaller
    {
        public static ListPersonDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPersonDetailsResponse listPersonDetailsResponse = new ListPersonDetailsResponse();

			listPersonDetailsResponse.HttpResponse = _ctx.HttpResponse;
			listPersonDetailsResponse.Code = _ctx.StringValue("ListPersonDetails.Code");
			listPersonDetailsResponse.Message = _ctx.StringValue("ListPersonDetails.Message");
			listPersonDetailsResponse.RequestId = _ctx.StringValue("ListPersonDetails.RequestId");
			listPersonDetailsResponse.PageNumber = _ctx.LongValue("ListPersonDetails.PageNumber");
			listPersonDetailsResponse.PageSize = _ctx.LongValue("ListPersonDetails.PageSize");
			listPersonDetailsResponse.TotalCount = _ctx.LongValue("ListPersonDetails.TotalCount");

			List<ListPersonDetailsResponse.ListPersonDetails_Datas> listPersonDetailsResponse_data = new List<ListPersonDetailsResponse.ListPersonDetails_Datas>();
			for (int i = 0; i < _ctx.Length("ListPersonDetails.Data.Length"); i++) {
				ListPersonDetailsResponse.ListPersonDetails_Datas datas = new ListPersonDetailsResponse.ListPersonDetails_Datas();
				datas.PersonId = _ctx.StringValue("ListPersonDetails.Data["+ i +"].PersonId");
				datas.Gender = _ctx.StringValue("ListPersonDetails.Data["+ i +"].Gender");
				datas.Age = _ctx.StringValue("ListPersonDetails.Data["+ i +"].Age");
				datas.Profession = _ctx.StringValue("ListPersonDetails.Data["+ i +"].Profession");
				datas.Address = _ctx.StringValue("ListPersonDetails.Data["+ i +"].Address");
				datas.Transportation = _ctx.StringValue("ListPersonDetails.Data["+ i +"].Transportation");
				datas.PersonType = _ctx.StringValue("ListPersonDetails.Data["+ i +"].PersonType");
				datas.HotSpotAddress = _ctx.StringValue("ListPersonDetails.Data["+ i +"].HotSpotAddress");
				datas.UpdateTime = _ctx.StringValue("ListPersonDetails.Data["+ i +"].UpdateTime");
				datas.PreferredColor = _ctx.StringValue("ListPersonDetails.Data["+ i +"].PreferredColor");
				datas.FaceSourceImage = _ctx.StringValue("ListPersonDetails.Data["+ i +"].FaceSourceImage");
				datas.FaceTargetImage = _ctx.StringValue("ListPersonDetails.Data["+ i +"].FaceTargetImage");
				datas.BodySourceImage = _ctx.StringValue("ListPersonDetails.Data["+ i +"].BodySourceImage");
				datas.BodyTargetImage = _ctx.StringValue("ListPersonDetails.Data["+ i +"].BodyTargetImage");
				datas.PrefOutTime = _ctx.StringValue("ListPersonDetails.Data["+ i +"].PrefOutTime");

				listPersonDetailsResponse_data.Add(datas);
			}
			listPersonDetailsResponse.Data = listPersonDetailsResponse_data;
        
			return listPersonDetailsResponse;
        }
    }
}
