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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeImageLibResponseUnmarshaller
    {
        public static DescribeImageLibResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeImageLibResponse describeImageLibResponse = new DescribeImageLibResponse();

			describeImageLibResponse.HttpResponse = context.HttpResponse;
			describeImageLibResponse.RequestId = context.StringValue("DescribeImageLib.RequestId");
			describeImageLibResponse.TotalCount = context.IntegerValue("DescribeImageLib.TotalCount");

			List<DescribeImageLibResponse.DescribeImageLib_ImageLib> describeImageLibResponse_imageLibList = new List<DescribeImageLibResponse.DescribeImageLib_ImageLib>();
			for (int i = 0; i < context.Length("DescribeImageLib.ImageLibList.Length"); i++) {
				DescribeImageLibResponse.DescribeImageLib_ImageLib imageLib = new DescribeImageLibResponse.DescribeImageLib_ImageLib();
				imageLib.ImageCount = context.IntegerValue("DescribeImageLib.ImageLibList["+ i +"].ImageCount");
				imageLib.ModifiedTime = context.StringValue("DescribeImageLib.ImageLibList["+ i +"].ModifiedTime");
				imageLib.Code = context.StringValue("DescribeImageLib.ImageLibList["+ i +"].Code");
				imageLib.Name = context.StringValue("DescribeImageLib.ImageLibList["+ i +"].Name");
				imageLib.Id = context.IntegerValue("DescribeImageLib.ImageLibList["+ i +"].Id");
				imageLib.Source = context.StringValue("DescribeImageLib.ImageLibList["+ i +"].Source");
				imageLib.Category = context.StringValue("DescribeImageLib.ImageLibList["+ i +"].Category");
				imageLib.ServiceModule = context.StringValue("DescribeImageLib.ImageLibList["+ i +"].ServiceModule");
				imageLib.Scene = context.StringValue("DescribeImageLib.ImageLibList["+ i +"].Scene");
				imageLib.Enable = context.StringValue("DescribeImageLib.ImageLibList["+ i +"].Enable");

				List<string> imageLib_bizTypes = new List<string>();
				for (int j = 0; j < context.Length("DescribeImageLib.ImageLibList["+ i +"].BizTypes.Length"); j++) {
					imageLib_bizTypes.Add(context.StringValue("DescribeImageLib.ImageLibList["+ i +"].BizTypes["+ j +"]"));
				}
				imageLib.BizTypes = imageLib_bizTypes;

				describeImageLibResponse_imageLibList.Add(imageLib);
			}
			describeImageLibResponse.ImageLibList = describeImageLibResponse_imageLibList;
        
			return describeImageLibResponse;
        }
    }
}
