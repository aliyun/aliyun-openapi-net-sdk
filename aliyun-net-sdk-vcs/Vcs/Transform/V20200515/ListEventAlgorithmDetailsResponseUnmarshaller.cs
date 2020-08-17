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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class ListEventAlgorithmDetailsResponseUnmarshaller
    {
        public static ListEventAlgorithmDetailsResponse Unmarshall(UnmarshallerContext context)
        {
			ListEventAlgorithmDetailsResponse listEventAlgorithmDetailsResponse = new ListEventAlgorithmDetailsResponse();

			listEventAlgorithmDetailsResponse.HttpResponse = context.HttpResponse;
			listEventAlgorithmDetailsResponse.Code = context.StringValue("ListEventAlgorithmDetails.Code");
			listEventAlgorithmDetailsResponse.Message = context.StringValue("ListEventAlgorithmDetails.Message");
			listEventAlgorithmDetailsResponse.PageNumber = context.IntegerValue("ListEventAlgorithmDetails.PageNumber");
			listEventAlgorithmDetailsResponse.PageSize = context.IntegerValue("ListEventAlgorithmDetails.PageSize");
			listEventAlgorithmDetailsResponse.RequestId = context.StringValue("ListEventAlgorithmDetails.RequestId");
			listEventAlgorithmDetailsResponse.Success = context.StringValue("ListEventAlgorithmDetails.Success");
			listEventAlgorithmDetailsResponse.TotalCount = context.IntegerValue("ListEventAlgorithmDetails.TotalCount");

			List<ListEventAlgorithmDetailsResponse.ListEventAlgorithmDetails_Datas> listEventAlgorithmDetailsResponse_data = new List<ListEventAlgorithmDetailsResponse.ListEventAlgorithmDetails_Datas>();
			for (int i = 0; i < context.Length("ListEventAlgorithmDetails.Data.Length"); i++) {
				ListEventAlgorithmDetailsResponse.ListEventAlgorithmDetails_Datas datas = new ListEventAlgorithmDetailsResponse.ListEventAlgorithmDetails_Datas();
				datas.CorpId = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].CorpId");
				datas.DataSourceId = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].DataSourceId");
				datas.EventType = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].EventType");
				datas.EventValue = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].EventValue");
				datas.ExtendValue = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].ExtendValue");
				datas.ExtraExtendValue = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].ExtraExtendValue");
				datas.FaceCount = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].FaceCount");
				datas.LeftTopX = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].LeftTopX");
				datas.LeftTopY = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].LeftTopY");
				datas.PicUrlPath = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].PicUrlPath");
				datas.PointX = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].PointX");
				datas.PointY = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].PointY");
				datas.RecordId = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].RecordId");
				datas.RightBottomX = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].RightBottomX");
				datas.RightBottomY = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].RightBottomY");
				datas.ShotTime = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].ShotTime");
				datas.SourceId = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].SourceId");
				datas.TargetPicUrlPath = context.StringValue("ListEventAlgorithmDetails.Data["+ i +"].TargetPicUrlPath");

				listEventAlgorithmDetailsResponse_data.Add(datas);
			}
			listEventAlgorithmDetailsResponse.Data = listEventAlgorithmDetailsResponse_data;
        
			return listEventAlgorithmDetailsResponse;
        }
    }
}
