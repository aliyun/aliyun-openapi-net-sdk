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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.imageenhan.Model.V20190930
{
	public class ImageBlindPicWatermarkResponse : AcsResponse
	{

		private string requestId;

		private ImageBlindPicWatermark_Data data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public ImageBlindPicWatermark_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ImageBlindPicWatermark_Data
		{

			private string watermarkImageURL;

			private string logoURL;

			public string WatermarkImageURL
			{
				get
				{
					return watermarkImageURL;
				}
				set	
				{
					watermarkImageURL = value;
				}
			}

			public string LogoURL
			{
				get
				{
					return logoURL;
				}
				set	
				{
					logoURL = value;
				}
			}
		}
	}
}
