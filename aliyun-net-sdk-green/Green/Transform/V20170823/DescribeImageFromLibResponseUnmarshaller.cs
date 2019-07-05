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
    public class DescribeImageFromLibResponseUnmarshaller
    {
        public static DescribeImageFromLibResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeImageFromLibResponse describeImageFromLibResponse = new DescribeImageFromLibResponse();

			describeImageFromLibResponse.HttpResponse = context.HttpResponse;
			describeImageFromLibResponse.RequestId = context.StringValue("DescribeImageFromLib.RequestId");
			describeImageFromLibResponse.PageSize = context.IntegerValue("DescribeImageFromLib.PageSize");
			describeImageFromLibResponse.CurrentPage = context.IntegerValue("DescribeImageFromLib.CurrentPage");
			describeImageFromLibResponse.TotalCount = context.IntegerValue("DescribeImageFromLib.TotalCount");

			List<DescribeImageFromLibResponse.DescribeImageFromLib_ImageFromLib> describeImageFromLibResponse_imageFromLibList = new List<DescribeImageFromLibResponse.DescribeImageFromLib_ImageFromLib>();
			for (int i = 0; i < context.Length("DescribeImageFromLib.ImageFromLibList.Length"); i++) {
				DescribeImageFromLibResponse.DescribeImageFromLib_ImageFromLib imageFromLib = new DescribeImageFromLibResponse.DescribeImageFromLib_ImageFromLib();
				imageFromLib.Image = context.StringValue("DescribeImageFromLib.ImageFromLibList["+ i +"].Image");
				imageFromLib.Thumbnail = context.StringValue("DescribeImageFromLib.ImageFromLibList["+ i +"].Thumbnail");
				imageFromLib.Id = context.LongValue("DescribeImageFromLib.ImageFromLibList["+ i +"].Id");
				imageFromLib.ImageHitCount = context.LongValue("DescribeImageFromLib.ImageFromLibList["+ i +"].ImageHitCount");
				imageFromLib.VideoHitCount = context.LongValue("DescribeImageFromLib.ImageFromLibList["+ i +"].VideoHitCount");
				imageFromLib.CreateTime = context.StringValue("DescribeImageFromLib.ImageFromLibList["+ i +"].CreateTime");

				describeImageFromLibResponse_imageFromLibList.Add(imageFromLib);
			}
			describeImageFromLibResponse.ImageFromLibList = describeImageFromLibResponse_imageFromLibList;
        
			return describeImageFromLibResponse;
        }
    }
}
