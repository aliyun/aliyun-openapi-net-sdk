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
using Aliyun.Acs.digitalstore.Model.V20200107;

namespace Aliyun.Acs.digitalstore.Transform.V20200107
{
    public class ListColorsResponseUnmarshaller
    {
        public static ListColorsResponse Unmarshall(UnmarshallerContext context)
        {
			ListColorsResponse listColorsResponse = new ListColorsResponse();

			listColorsResponse.HttpResponse = context.HttpResponse;
			listColorsResponse.PageSize = context.IntegerValue("ListColors.PageSize");
			listColorsResponse.TotalCount = context.IntegerValue("ListColors.TotalCount");
			listColorsResponse.PageNumber = context.IntegerValue("ListColors.PageNumber");
			listColorsResponse.RequestId = context.StringValue("ListColors.RequestId");
			listColorsResponse.Success = context.BooleanValue("ListColors.Success");

			List<ListColorsResponse.ListColors_ColorModel> listColorsResponse_colors = new List<ListColorsResponse.ListColors_ColorModel>();
			for (int i = 0; i < context.Length("ListColors.Colors.Length"); i++) {
				ListColorsResponse.ListColors_ColorModel colorModel = new ListColorsResponse.ListColors_ColorModel();
				colorModel.Description = context.StringValue("ListColors.Colors["+ i +"].Description");
				colorModel.Name = context.StringValue("ListColors.Colors["+ i +"].Name");
				colorModel.CreateDate = context.StringValue("ListColors.Colors["+ i +"].CreateDate");
				colorModel.Code = context.StringValue("ListColors.Colors["+ i +"].Code");
				colorModel.UpdateDate = context.StringValue("ListColors.Colors["+ i +"].UpdateDate");
				colorModel.ColorId = context.StringValue("ListColors.Colors["+ i +"].ColorId");
				colorModel.Disable = context.IntegerValue("ListColors.Colors["+ i +"].Disable");

				listColorsResponse_colors.Add(colorModel);
			}
			listColorsResponse.Colors = listColorsResponse_colors;
        
			return listColorsResponse;
        }
    }
}
