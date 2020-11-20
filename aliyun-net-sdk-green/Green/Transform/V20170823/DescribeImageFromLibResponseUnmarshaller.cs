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
        public static DescribeImageFromLibResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImageFromLibResponse describeImageFromLibResponse = new DescribeImageFromLibResponse();

			describeImageFromLibResponse.HttpResponse = _ctx.HttpResponse;
			describeImageFromLibResponse.RequestId = _ctx.StringValue("DescribeImageFromLib.RequestId");
			describeImageFromLibResponse.PageSize = _ctx.IntegerValue("DescribeImageFromLib.PageSize");
			describeImageFromLibResponse.CurrentPage = _ctx.IntegerValue("DescribeImageFromLib.CurrentPage");
			describeImageFromLibResponse.TotalCount = _ctx.IntegerValue("DescribeImageFromLib.TotalCount");

			List<DescribeImageFromLibResponse.DescribeImageFromLib_ImageFromLib> describeImageFromLibResponse_imageFromLibList = new List<DescribeImageFromLibResponse.DescribeImageFromLib_ImageFromLib>();
			for (int i = 0; i < _ctx.Length("DescribeImageFromLib.ImageFromLibList.Length"); i++) {
				DescribeImageFromLibResponse.DescribeImageFromLib_ImageFromLib imageFromLib = new DescribeImageFromLibResponse.DescribeImageFromLib_ImageFromLib();
				imageFromLib.Image = _ctx.StringValue("DescribeImageFromLib.ImageFromLibList["+ i +"].Image");
				imageFromLib.Thumbnail = _ctx.StringValue("DescribeImageFromLib.ImageFromLibList["+ i +"].Thumbnail");
				imageFromLib.Id = _ctx.LongValue("DescribeImageFromLib.ImageFromLibList["+ i +"].Id");
				imageFromLib.ImageHitCount = _ctx.LongValue("DescribeImageFromLib.ImageFromLibList["+ i +"].ImageHitCount");
				imageFromLib.VideoHitCount = _ctx.LongValue("DescribeImageFromLib.ImageFromLibList["+ i +"].VideoHitCount");
				imageFromLib.CreateTime = _ctx.StringValue("DescribeImageFromLib.ImageFromLibList["+ i +"].CreateTime");

				describeImageFromLibResponse_imageFromLibList.Add(imageFromLib);
			}
			describeImageFromLibResponse.ImageFromLibList = describeImageFromLibResponse_imageFromLibList;
        
			return describeImageFromLibResponse;
        }
    }
}
