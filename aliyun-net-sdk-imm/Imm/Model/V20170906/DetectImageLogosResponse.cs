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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class DetectImageLogosResponse : AcsResponse
	{

		private string requestId;

		private string imageUri;

		private List<DetectImageLogos_LogosItem> logos;

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

		public string ImageUri
		{
			get
			{
				return imageUri;
			}
			set	
			{
				imageUri = value;
			}
		}

		public List<DetectImageLogos_LogosItem> Logos
		{
			get
			{
				return logos;
			}
			set	
			{
				logos = value;
			}
		}

		public class DetectImageLogos_LogosItem
		{

			private string logoName;

			private float? logoConfidence;

			private DetectImageLogos_LogoBoundary logoBoundary;

			public string LogoName
			{
				get
				{
					return logoName;
				}
				set	
				{
					logoName = value;
				}
			}

			public float? LogoConfidence
			{
				get
				{
					return logoConfidence;
				}
				set	
				{
					logoConfidence = value;
				}
			}

			public DetectImageLogos_LogoBoundary LogoBoundary
			{
				get
				{
					return logoBoundary;
				}
				set	
				{
					logoBoundary = value;
				}
			}

			public class DetectImageLogos_LogoBoundary
			{

				private int? width;

				private int? height;

				private int? top;

				private int? left;

				public int? Width
				{
					get
					{
						return width;
					}
					set	
					{
						width = value;
					}
				}

				public int? Height
				{
					get
					{
						return height;
					}
					set	
					{
						height = value;
					}
				}

				public int? Top
				{
					get
					{
						return top;
					}
					set	
					{
						top = value;
					}
				}

				public int? Left
				{
					get
					{
						return left;
					}
					set	
					{
						left = value;
					}
				}
			}
		}
	}
}
