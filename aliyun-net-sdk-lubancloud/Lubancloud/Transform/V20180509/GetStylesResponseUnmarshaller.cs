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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.lubancloud.Model.V20180509;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.lubancloud.Transform.V20180509
{
    public class GetStylesResponseUnmarshaller
    {
        public static GetStylesResponse Unmarshall(UnmarshallerContext context)
        {
			GetStylesResponse getStylesResponse = new GetStylesResponse();

			getStylesResponse.HttpResponse = context.HttpResponse;
			getStylesResponse.RequestId = context.StringValue("GetStyles.RequestId");

			List<GetStylesResponse.GetStyles_Style> getStylesResponse_styles = new List<GetStylesResponse.GetStyles_Style>();
			for (int i = 0; i < context.Length("GetStyles.Styles.Length"); i++) {
				GetStylesResponse.GetStyles_Style style = new GetStylesResponse.GetStyles_Style();
				style.Id = context.LongValue("GetStyles.Styles["+ i +"].Id");
				style.Name = context.StringValue("GetStyles.Styles["+ i +"].Name");
				style.ParentId = context.LongValue("GetStyles.Styles["+ i +"].ParentId");
				style.PreviewUrl = context.StringValue("GetStyles.Styles["+ i +"].PreviewUrl");

				List<GetStylesResponse.GetStyles_Style.GetStyles_SubStyle> style_subStyles = new List<GetStylesResponse.GetStyles_Style.GetStyles_SubStyle>();
				for (int j = 0; j < context.Length("GetStyles.Styles["+ i +"].SubStyles.Length"); j++) {
					GetStylesResponse.GetStyles_Style.GetStyles_SubStyle subStyle = new GetStylesResponse.GetStyles_Style.GetStyles_SubStyle();
					subStyle.Id = context.LongValue("GetStyles.Styles["+ i +"].SubStyles["+ j +"].Id");
					subStyle.Name = context.StringValue("GetStyles.Styles["+ i +"].SubStyles["+ j +"].Name");
					subStyle.ParentId = context.LongValue("GetStyles.Styles["+ i +"].SubStyles["+ j +"].ParentId");
					subStyle.PreviewUrl = context.StringValue("GetStyles.Styles["+ i +"].SubStyles["+ j +"].PreviewUrl");

					style_subStyles.Add(subStyle);
				}
				style.SubStyles = style_subStyles;

				getStylesResponse_styles.Add(style);
			}
			getStylesResponse.Styles = getStylesResponse_styles;
        
			return getStylesResponse;
        }
    }
}