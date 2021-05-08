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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class ListMediaNameResponseUnmarshaller
    {
        public static ListMediaNameResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMediaNameResponse listMediaNameResponse = new ListMediaNameResponse();

			listMediaNameResponse.HttpResponse = _ctx.HttpResponse;
			listMediaNameResponse.Code = _ctx.StringValue("ListMediaName.Code");
			listMediaNameResponse.Success = _ctx.BooleanValue("ListMediaName.Success");
			listMediaNameResponse.Message = _ctx.StringValue("ListMediaName.Message");
			listMediaNameResponse.RequestId = _ctx.StringValue("ListMediaName.RequestId");
			listMediaNameResponse.PageNumber = _ctx.IntegerValue("ListMediaName.PageNumber");
			listMediaNameResponse.PageSize = _ctx.IntegerValue("ListMediaName.PageSize");
			listMediaNameResponse.Total = _ctx.LongValue("ListMediaName.Total");

			List<ListMediaNameResponse.ListMediaName_Media> listMediaNameResponse_model = new List<ListMediaNameResponse.ListMediaName_Media>();
			for (int i = 0; i < _ctx.Length("ListMediaName.Model.Length"); i++) {
				ListMediaNameResponse.ListMediaName_Media media = new ListMediaNameResponse.ListMediaName_Media();
				media.MediaName = _ctx.StringValue("ListMediaName.Model["+ i +"].MediaName");
				media.MediaId = _ctx.StringValue("ListMediaName.Model["+ i +"].MediaId");

				listMediaNameResponse_model.Add(media);
			}
			listMediaNameResponse.Model = listMediaNameResponse_model;
        
			return listMediaNameResponse;
        }
    }
}
