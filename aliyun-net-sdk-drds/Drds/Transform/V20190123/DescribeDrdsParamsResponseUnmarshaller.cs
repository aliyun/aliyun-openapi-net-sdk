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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeDrdsParamsResponseUnmarshaller
    {
        public static DescribeDrdsParamsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsParamsResponse describeDrdsParamsResponse = new DescribeDrdsParamsResponse();

			describeDrdsParamsResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsParamsResponse.RequestId = _ctx.StringValue("DescribeDrdsParams.RequestId");
			describeDrdsParamsResponse.Success = _ctx.BooleanValue("DescribeDrdsParams.Success");

			List<DescribeDrdsParamsResponse.DescribeDrdsParams_ListItem> describeDrdsParamsResponse_list = new List<DescribeDrdsParamsResponse.DescribeDrdsParams_ListItem>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsParams.List.Length"); i++) {
				DescribeDrdsParamsResponse.DescribeDrdsParams_ListItem listItem = new DescribeDrdsParamsResponse.DescribeDrdsParams_ListItem();
				listItem.ParamName = _ctx.StringValue("DescribeDrdsParams.List["+ i +"].ParamName");
				listItem.ParamEnglishName = _ctx.StringValue("DescribeDrdsParams.List["+ i +"].ParamEnglishName");
				listItem.ParamVariableName = _ctx.StringValue("DescribeDrdsParams.List["+ i +"].ParamVariableName");
				listItem.ParamDesc = _ctx.StringValue("DescribeDrdsParams.List["+ i +"].ParamDesc");
				listItem.ParamValue = _ctx.StringValue("DescribeDrdsParams.List["+ i +"].ParamValue");
				listItem.DbName = _ctx.StringValue("DescribeDrdsParams.List["+ i +"].DbName");
				listItem.ParamDefaultValue = _ctx.StringValue("DescribeDrdsParams.List["+ i +"].ParamDefaultValue");
				listItem.ParamRanges = _ctx.StringValue("DescribeDrdsParams.List["+ i +"].ParamRanges");
				listItem.ParamLevel = _ctx.StringValue("DescribeDrdsParams.List["+ i +"].ParamLevel");
				listItem.ParamType = _ctx.StringValue("DescribeDrdsParams.List["+ i +"].ParamType");
				listItem.NeedRestart = _ctx.BooleanValue("DescribeDrdsParams.List["+ i +"].NeedRestart");
				listItem.UserVisible = _ctx.BooleanValue("DescribeDrdsParams.List["+ i +"].UserVisible");

				describeDrdsParamsResponse_list.Add(listItem);
			}
			describeDrdsParamsResponse.List = describeDrdsParamsResponse_list;
        
			return describeDrdsParamsResponse;
        }
    }
}
